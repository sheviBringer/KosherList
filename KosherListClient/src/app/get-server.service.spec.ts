import { TestBed } from '@angular/core/testing';

import { GetServerService } from './get-server.service';

describe('GetServerService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: GetServerService = TestBed.get(GetServerService);
    expect(service).toBeTruthy();
  });
});
