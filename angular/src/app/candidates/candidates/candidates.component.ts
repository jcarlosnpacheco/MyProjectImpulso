import { Component, Injector } from "@angular/core";
import { appModuleAnimation } from "@shared/animations/routerTransition";
import {
  PagedListingComponentBase,
  PagedRequestDto,
} from "@shared/paged-listing-component-base";
import { CandidateDto, CandidateDtoPagedResultDto, CandidateServiceProxy } from "@shared/service-proxies/service-proxies";
import { finalize } from "rxjs/operators";

@Component({
  templateUrl: "./candidates.component.html",
  animations: [appModuleAnimation()],
})
export class CandidatesComponent extends PagedListingComponentBase<CandidateDto> {
  candidates: CandidateDto[] = [];
  constructor(injector: Injector, private _candidateService: CandidateServiceProxy) {
    super(injector);
  }

  protected list(
    request: PagedRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    this._candidateService
      .getAll(
        request.skipCount,
        request.maxResultCount
      )
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: CandidateDtoPagedResultDto) => {
        this.candidates = result.items;
        this.showPaging(result, pageNumber);
      });
  }
  protected delete(entity: CandidateDto): void {
    throw new Error("Method not implemented.");
  }
}
