using SipSis.BLL.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipSis.BLL.Repository.Service
{
    public class EntityService
    {
        public EntityService()
        {
            _userService = new UserRepository();
            _cargoService = new CargoRepository();
            _categoryService = new CategoryRepository();
            _customerService = new CustomerRepository();
            _invoiceService = new InvoiceRepository();
            _invoiceDetailService = new InvoiceDetailRepository();
            _orderService = new OrderRepository();
            _orderStatusService = new OrderStatusRepository();
            _productService = new ProductRepository();
            _marketService = new MarketRepository();
            _supplierService = new SupplierRepository();
            _warrantyOrderService = new WarrantyOrderRepository();
            _wendDateService = new WendDateRepository();


        }
        private UserRepository _userService;

        public UserRepository UserService
        {
            get { return _userService; }
            set { _userService = value; }
        }

        private CargoRepository _cargoService;

        public CargoRepository CargoService
        {
            get { return _cargoService; }
            set { _cargoService = value; }
        }

        private CategoryRepository _categoryService;

        public CategoryRepository CategoryService
        {
            get { return _categoryService; }
            set { _categoryService = value; }
        }

        private CustomerRepository _customerService;

        public CustomerRepository CustomerService
        {
            get { return _customerService; }
            set { _customerService = value; }
        }

        private InvoiceRepository _invoiceService;

        public InvoiceRepository InvoiceService
        {
            get { return _invoiceService; }
            set { _invoiceService = value; }
        }

        private InvoiceDetailRepository _invoiceDetailService;

        public InvoiceDetailRepository InvoiceDetailService
        {
            get { return _invoiceDetailService; }
            set { _invoiceDetailService = value; }
        }

        private OrderRepository _orderService;

        public OrderRepository OrderService
        {
            get { return _orderService; }
            set { _orderService = value; }
        }

        private OrderStatusRepository _orderStatusService;

        public OrderStatusRepository OrderStatusService
        {
            get { return _orderStatusService; }
            set { _orderStatusService = value; }
        }

        private ProductRepository _productService;

        public ProductRepository ProductService
        {
            get { return _productService; }
            set { _productService = value; }
        }

       

        private MarketRepository _marketService;

        public MarketRepository MarketService
        {
            get { return _marketService; }
            set { _marketService = value; }
        }

        private SupplierRepository _supplierService;

        public SupplierRepository SupplierService
        {
            get { return _supplierService; }
            set { _supplierService = value; }
        }

        private WarrantyOrderRepository _warrantyOrderService;

        public WarrantyOrderRepository WarrantyOrderService
        {
            get { return _warrantyOrderService; }
            set { _warrantyOrderService = value; }
        }

        private WendDateRepository _wendDateService;

        public WendDateRepository WendDateService
        {
            get { return _wendDateService; }
            set { _wendDateService = value; }
        }


    }
}
