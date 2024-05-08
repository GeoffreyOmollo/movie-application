﻿using FC.Codeflix.Catalog.IntegrationTests.Application.UseCases.Genre.Common;
using Xunit;

namespace FC.Codeflix.Catalog.IntegrationTests.Application.UseCases.Genre.DeleteGenre;

[CollectionDefinition(nameof(DeleteGenreTestFixture))]
public class DeleteGenreTestFixtureCollection : ICollectionFixture<DeleteGenreTestFixture> { }

public class DeleteGenreTestFixture : GenreUseCaseBaseFixture
{
}
