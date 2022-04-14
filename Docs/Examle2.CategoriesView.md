### ��������� � DataGrid ����� ����� (CategoriesView).
��� ������������� ������������ ��� �����: ������ �������� ����� `DataGrid` �� ���������. 
��� ����� ��� ����������� ������� *ItemsFilterStyle.xaml*, ������� ���������� ��������
� ������ �������� �������. ����� ����� ��� �������� `DataGrid` � ������� 
���������� � ��������� ������� ������. ������ �� �������� ����������� ��������� �����
`ColumnFilter` � ������������ � �������������� �������� ������ ����������.
#### ��� ��� ��������
![DataGrid column filter](Picture/Pic5.gif "���.1")
#### ��� ������������
� ������� ��� ���������� �������� ������ �� *ItemsFilterStyle.xaml*.

File *App.xaml*:

    <Application x:Class="Northwind.NET.Sample.App"
                 ...
    >
        <Application.Resources>
            <ResourceDictionary>
                <ResourceDictionary.MergedDictionaries>
                    ...
                    <ResourceDictionary Source="Themes/ItemsFilterStyle.xaml" />
		       ...
                </ResourceDictionary.MergedDictionaries>
            </ResourceDictionary>
        </Application.Resources>
    </Application>

#### ��� ��� ��������
������������ ��������� �������� ���������� `ColumnFilter`� ��������� `DataGrid` ����� ��������������� 
����� ��� `DataGridColumnHeader`.

File *ItemsFilterStyle.xaml*:

    <ResourceDictionary 
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                  ...  
                  xmlns:bsFilter="http://schemas.bolapansoft.com/xaml/Controls/ItemsFilter"
                  ...>
    ...
        <Style x:Key="DataGridColumnHeaderStyle" TargetType="{x:Type DataGridColumnHeader}">
            <Setter Property="Template">
                <Setter.Value>
                    <ControlTemplate TargetType="{x:Type DataGridColumnHeader}">
                        <Grid >
                            ...
                            <bsFilter:ColumnFilter 
                               ParentCollection="{Binding ItemsSource,
                               RelativeSource={RelativeSource FindAncestor,
             		                    AncestorType={x:Type DataGrid}}}" />
                            ...
                        </Grid>
                    </ControlTemplate>
                </Setter>
            </Setter>
        </Style>
        <Style TargetType="{x:Type DataGrid}">
            <Setter Property="ColumnHeaderStyle" 
                Value="{StaticResource DataGridColumnHeaderStyle}" />
        </Style>
    </ResourceDictionary>



[�����](Examle1.EmployeesView.md "������������� �������� �������� ���������� FilterDataGrid (EmployeesView)") <<
[����������](Readme.md) >>
[������](Examle3.ProductsView.md "��������� �������� ���� �������. (ProductsView)")