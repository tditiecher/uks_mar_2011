using System;
using System.Collections.Generic;
using nothinbutdotnetstore.web.application.model;
using nothinbutdotnetstore.web.application.stubs;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.core.aspnet;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
    public class ViewTheProductsInADepartment : ApplicationBehaviour
    {
        RenderingGateway rendering_gateway;
        StoreCatalog product_repository;

        public ViewTheProductsInADepartment() : this(new WebFormRenderer(),
                                                     Stub.with<StubStoreCatalog>())
        {
        }

        public ViewTheProductsInADepartment(RenderingGateway rendering_gateway, StoreCatalog product_repository)
        {
            this.product_repository = product_repository;
            this.rendering_gateway = rendering_gateway;
        }

        public void process(Request request)
        {
            rendering_gateway.render(retrieve(product_repository.get_the_products_in, request.map<Department>()));
        }

        ReportModel retrieve<ReportModel, ParameterType>(RetrievalFunction<ReportModel,ParameterType> retrieval_function, ParameterType parameter)
        {
            return retrieval_function(parameter);
        }
    }

    public delegate ReportModel RetrievalFunction<ReportModel, ParameterType>(ParameterType parameter);
}