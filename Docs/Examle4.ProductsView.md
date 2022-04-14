### 4.	������������� ������������� ��������� c �������� � ���������� ������. (ProductsView)

��� ����������� �������� ������������ ���������� *ItemsFilter* ���������� ��������� ���������. 
����������� ����� ����������, `FilterPresenter`, ����� ��� � ������ �������� Filter(s), 
������� �� ��������� ��� ����������, �� ��������������� � `DataGrid`, `ItemsSelector` ��� `ItemsControl`.
������ ����� ��� �������� � �������������� ���������, ������������ � ���������� `FilterPresenter`
��� ��� ��������. � �� ������������� ��������� �� ����� ������������ ���, ��� ��� ����������
� ��������, �� ��������� ���� ������������. ���� ��� ������������� `FilterPresenter` �� �������� 
�� ������������� ���������, � ��������������� ���� ���������, �� ������������ ��������� 
������������� ��������� �� ��������� (� �� ���� ��� ������� ���������� ��������� �� ���� ����������). 
����������� ������� ����������� �� `ItemsControl` �������� ���������� ���������� ��������� 
��� ��������� �������� `ItemsControl.ItemsSource`. ����� �������, ��� �������������� `FilterView` 
� `ItemsControl` ����������, ����� ��� ��� ���� ���������� � ������ ���������� ��������� 
(��� ������ ������������� ���������).  

� ������������ ���������� ����� � ����� *ProductsView.xaml* ������� ���������� `CategoryFilterView` ��������� ��� `DataGrid`,
�� ��������� ������������ ���������, ������� ������� `DataGrid`.

#### ��� ������������
File *ProductsView.xaml*:

    ...
    <DataGrid x:Name="productDataGrid"
                      ItemsSource="{Binding Path=Products,
                                            Source={StaticResource Workspace}}">
    ...

File *CategoryFilterView.xaml.cs*:
    
    public partial class CategoryFilterView: MultiValueFilterView {
            public CategoryFilterView() {
                InitializeComponent();
                // Define Filter that must be use.
                EqualFilterInitializer initializer = new EqualFilterInitializer();
                // Get FilterPresenter that connected to the same collection Workspace.This.Products.
                FilterPresenter productsCollectionViewFilterPresenter = 
                    FilterPresenter.TryGet(Workspace.This.Products);
                // Get EqualFilter that use Category item property.
                EqualFilter filter = 
                    ((EqualFilter)(productsCollectionViewFilterPresenter.TryGetFilter("Category", initializer)));
                // Use instance of EqualFilter as Model.
                Model = filter;
            }
        }
#### ��� ��� ��������
��������� `FilterPresenter` ������ �������� � ������������� ���������, ��� �������� �� ������. 
��������� � �������� `DataGrid.ItemsSource` �� ��������� ��������������� �� ���� ���������, 
`DataGrid` ��������� � ���������� ������������� ��������� �� ���������. ��� ��������� ���������� 
`FilterPresenter` � ����� `FilterPresenter.TryGet(Workspace.This.Products)` ����� ���������� 
��������������� ���������, � �������� ���������� � ���� �� ������ ���������� ������������� ��������� 
�� ���������. �� ���� ����, `CategoryFilterView` ����� ���������� ���� � ��������� ���� � 
���������� ������������� ��������� ������ �� ��� ��������, ������������ ��� �������������. 

� ����� *OrdersView.xaml* � �������������� ������ ������ Product �������� ������������ ������������� ���������
�� ��������� ��� `Workspace.This.Products`, ������� ��� �������� ������� � ����� `ProductsView`
� ������ �������������� ������ `Product` �����  *OrdersView.xaml* � ����������� ������ ��������
���������� `ComboBox` ������������ ������ ��������������� ��������. 

��������, ��� ��������� �������, ������������ � ���������� �����, ��� ������������ ������ ��� �������������� 
������� *Product* �����  *OrdersView.xaml* ����� �������� ������ �������� �� ��������� Meat/Poultry:

![ProductView, ComboBox in Edit template](Picture/Pic6.gif "���.6")

[�����](Examle3.ProductsView.md "��������� �������� ���� �������. (ProductsView)") <<
[����������](Readme.md) >>
[������](Examle5.OrdersView.md "���������� ��������� � ���������������� �������� ����������. (OrdersView)")
