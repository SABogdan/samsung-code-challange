import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
  
export class FetchDataComponent {
  public adressBook: AddressBook[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<AddressBook[]>(baseUrl + 'addressbook').subscribe(result => {
      this.adressBook = result;
    }, error => console.error(error));
  }

}

interface AddressBook {
  name: string;
  address: string;
}
