import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { BreadcrumbService } from 'xng-breadcrumb';

@Component({
  selector: 'app-section-head',
  templateUrl: './section-head.component.html',
  styleUrls: ['./section-head.component.scss'],
})
export class SectionHeadComponent implements OnInit {
  breadcrumb$: Observable<any[]>;

  constructor(private bcService: BreadcrumbService) {}

  ngOnInit(): void {
    this.breadcrumb$ = this.bcService.breadcrumbs$;
  }
}
