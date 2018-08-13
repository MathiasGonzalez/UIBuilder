import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'catalog',
  templateUrl: './catalog.html',
  styleUrls: ['./catalog.css']
})
export class Catalog implements OnInit {

  @Input() items: Array<any>;

  constructor() { }

  ngOnInit() {
  }

}
