using System.Collections.Generic;



namespace _03_RestWithAspNetCore_Person.Data.Converter.Contract
{
    public interface IParse<O,D>
    {
        D Parse(O origem);
        List<D> Parse(List<O> origem);

    }
}



