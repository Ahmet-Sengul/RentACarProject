using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Add(DocuSign.eSign.Model.Brand brand)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public void Delete(DocuSign.eSign.Model.Brand brand)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }

        public void Update(DocuSign.eSign.Model.Brand brand)
        {
            throw new NotImplementedException();
        }

        List<DocuSign.eSign.Model.Brand> IBrandService.GetAll()
        {
            throw new NotImplementedException();
        }

        DocuSign.eSign.Model.Brand IBrandService.GetById(int brandId)
        {
            throw new NotImplementedException();
        }
    }
}
