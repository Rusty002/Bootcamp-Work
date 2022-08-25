import { Component } from '@angular/core';
import { SharedService } from '../Service/shared.service';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Country } from '../../Models/Country';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {

    constructor(private service: SharedService, private formBuilder: FormBuilder) { }

    //Declarations of variable to be used
    countrylist: any = [];
    penaltyForm!: FormGroup;
    submitted = false;
    country!: Country;
    countryID!: number;

    ngOnInit(): void {
        this.refreshCounties();
        this.penaltyForm = this.formBuilder.group({
            startDate: ['', Validators.required],
            lastDate: ['', Validators.required],
            country: ['', Validators.required]
        })
    }

    refreshCounties() {
        console.log("Before Getting List");
        this.service.getCountries().subscribe(data => {
            this.countrylist = data;
        });
    }

    setCountry() {
        this.country = this.penaltyForm.value.country;
        this.countryID = this.country.ID;
    }

    onSubmit() {
        var penalty = {
            startdate: this.penaltyForm.get("startDate").value,
            lastdate: this.penaltyForm.get("lastDate").value,
            CountryID: this.penaltyForm.get("country").value
        }
        console.log(penalty);
        this.service.penalty(penalty).subscribe(res => {
            console.log(res)
        });
            
    }
}
