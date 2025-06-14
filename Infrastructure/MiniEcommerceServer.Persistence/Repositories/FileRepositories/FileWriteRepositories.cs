﻿using File = MiniEcommerceServer.Domain.Entities.File;

namespace MiniEcommerceServer.Persistence.Repositories.FileRepositories
{
    public class FileWriteRepositories : WriteRepository<File>, IFileWriteRepository
    {
        public FileWriteRepositories(ECommerceAPIContext context) : base(context)
        {
        }
    }
}
