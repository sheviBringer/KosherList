import { TestBed } from '@angular/core/testing';

import { UpdatesService } from './updates.service';

describe('UpdatesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: UpdatesService = TestBed.get(UpdatesService);
    expect(service).toBeTruthy();
  });
});
