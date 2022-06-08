import { Component, OnInit } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  templateUrl: './candidates.component.html',
  animations: [appModuleAnimation()]
})
export class CandidatesComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
