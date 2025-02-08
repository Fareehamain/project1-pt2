﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("EmployeesModel", "FK__Assignmen__Emplo__3A81B327", "Employees", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(project_pt4.Employee), "Assignments", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(project_pt4.Assignment), true)]

#endregion

namespace project_pt4
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EmployeesEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EmployeesEntities object using the connection string found in the 'EmployeesEntities' section of the application configuration file.
        /// </summary>
        public EmployeesEntities() : base("name=EmployeesEntities", "EmployeesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeesEntities object.
        /// </summary>
        public EmployeesEntities(string connectionString) : base(connectionString, "EmployeesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmployeesEntities object.
        /// </summary>
        public EmployeesEntities(EntityConnection connection) : base(connection, "EmployeesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Assignment> Assignments
        {
            get
            {
                if ((_Assignments == null))
                {
                    _Assignments = base.CreateObjectSet<Assignment>("Assignments");
                }
                return _Assignments;
            }
        }
        private ObjectSet<Assignment> _Assignments;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Employee> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employee>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employee> _Employees;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Assignments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAssignments(Assignment assignment)
        {
            base.AddObject("Assignments", assignment);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployees(Employee employee)
        {
            base.AddObject("Employees", employee);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeesModel", Name="Assignment")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Assignment : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Assignment object.
        /// </summary>
        /// <param name="assignmentID">Initial value of the AssignmentID property.</param>
        /// <param name="dateAssigned">Initial value of the DateAssigned property.</param>
        /// <param name="ownerFirstName">Initial value of the OwnerFirstName property.</param>
        /// <param name="ownerLastName">Initial value of the OwnerLastName property.</param>
        /// <param name="address">Initial value of the Address property.</param>
        /// <param name="problemDescription">Initial value of the ProblemDescription property.</param>
        public static Assignment CreateAssignment(global::System.Int32 assignmentID, global::System.DateTime dateAssigned, global::System.String ownerFirstName, global::System.String ownerLastName, global::System.String address, global::System.String problemDescription)
        {
            Assignment assignment = new Assignment();
            assignment.AssignmentID = assignmentID;
            assignment.DateAssigned = dateAssigned;
            assignment.OwnerFirstName = ownerFirstName;
            assignment.OwnerLastName = ownerLastName;
            assignment.Address = address;
            assignment.ProblemDescription = problemDescription;
            return assignment;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AssignmentID
        {
            get
            {
                return _AssignmentID;
            }
            set
            {
                if (_AssignmentID != value)
                {
                    OnAssignmentIDChanging(value);
                    ReportPropertyChanging("AssignmentID");
                    _AssignmentID = StructuralObject.SetValidValue(value, "AssignmentID");
                    ReportPropertyChanged("AssignmentID");
                    OnAssignmentIDChanged();
                }
            }
        }
        private global::System.Int32 _AssignmentID;
        partial void OnAssignmentIDChanging(global::System.Int32 value);
        partial void OnAssignmentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateAssigned
        {
            get
            {
                return _DateAssigned;
            }
            set
            {
                OnDateAssignedChanging(value);
                ReportPropertyChanging("DateAssigned");
                _DateAssigned = StructuralObject.SetValidValue(value, "DateAssigned");
                ReportPropertyChanged("DateAssigned");
                OnDateAssignedChanged();
            }
        }
        private global::System.DateTime _DateAssigned;
        partial void OnDateAssignedChanging(global::System.DateTime value);
        partial void OnDateAssignedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String OwnerFirstName
        {
            get
            {
                return _OwnerFirstName;
            }
            set
            {
                OnOwnerFirstNameChanging(value);
                ReportPropertyChanging("OwnerFirstName");
                _OwnerFirstName = StructuralObject.SetValidValue(value, false, "OwnerFirstName");
                ReportPropertyChanged("OwnerFirstName");
                OnOwnerFirstNameChanged();
            }
        }
        private global::System.String _OwnerFirstName;
        partial void OnOwnerFirstNameChanging(global::System.String value);
        partial void OnOwnerFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String OwnerLastName
        {
            get
            {
                return _OwnerLastName;
            }
            set
            {
                OnOwnerLastNameChanging(value);
                ReportPropertyChanging("OwnerLastName");
                _OwnerLastName = StructuralObject.SetValidValue(value, false, "OwnerLastName");
                ReportPropertyChanged("OwnerLastName");
                OnOwnerLastNameChanged();
            }
        }
        private global::System.String _OwnerLastName;
        partial void OnOwnerLastNameChanging(global::System.String value);
        partial void OnOwnerLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, false, "Address");
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, true, "Phone");
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ProblemDescription
        {
            get
            {
                return _ProblemDescription;
            }
            set
            {
                OnProblemDescriptionChanging(value);
                ReportPropertyChanging("ProblemDescription");
                _ProblemDescription = StructuralObject.SetValidValue(value, false, "ProblemDescription");
                ReportPropertyChanged("ProblemDescription");
                OnProblemDescriptionChanged();
            }
        }
        private global::System.String _ProblemDescription;
        partial void OnProblemDescriptionChanging(global::System.String value);
        partial void OnProblemDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> Completed
        {
            get
            {
                return _Completed;
            }
            set
            {
                OnCompletedChanging(value);
                ReportPropertyChanging("Completed");
                _Completed = StructuralObject.SetValidValue(value, "Completed");
                ReportPropertyChanged("Completed");
                OnCompletedChanged();
            }
        }
        private Nullable<global::System.Boolean> _Completed;
        partial void OnCompletedChanging(Nullable<global::System.Boolean> value);
        partial void OnCompletedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                OnEmployeeIDChanging(value);
                ReportPropertyChanging("EmployeeID");
                _EmployeeID = StructuralObject.SetValidValue(value, "EmployeeID");
                ReportPropertyChanged("EmployeeID");
                OnEmployeeIDChanged();
            }
        }
        private Nullable<global::System.Int32> _EmployeeID;
        partial void OnEmployeeIDChanging(Nullable<global::System.Int32> value);
        partial void OnEmployeeIDChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EmployeesModel", "FK__Assignmen__Emplo__3A81B327", "Employees")]
        public Employee Employee
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("EmployeesModel.FK__Assignmen__Emplo__3A81B327", "Employees").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("EmployeesModel.FK__Assignmen__Emplo__3A81B327", "Employees").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Employee> EmployeeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employee>("EmployeesModel.FK__Assignmen__Emplo__3A81B327", "Employees");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employee>("EmployeesModel.FK__Assignmen__Emplo__3A81B327", "Employees", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmployeesModel", Name="Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="employeeID">Initial value of the EmployeeID property.</param>
        /// <param name="first_name">Initial value of the first_name property.</param>
        /// <param name="last_name">Initial value of the last_name property.</param>
        public static Employee CreateEmployee(global::System.Int32 employeeID, global::System.String first_name, global::System.String last_name)
        {
            Employee employee = new Employee();
            employee.EmployeeID = employeeID;
            employee.first_name = first_name;
            employee.last_name = last_name;
            return employee;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                if (_EmployeeID != value)
                {
                    OnEmployeeIDChanging(value);
                    ReportPropertyChanging("EmployeeID");
                    _EmployeeID = StructuralObject.SetValidValue(value, "EmployeeID");
                    ReportPropertyChanged("EmployeeID");
                    OnEmployeeIDChanged();
                }
            }
        }
        private global::System.Int32 _EmployeeID;
        partial void OnEmployeeIDChanging(global::System.Int32 value);
        partial void OnEmployeeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String first_name
        {
            get
            {
                return _first_name;
            }
            set
            {
                Onfirst_nameChanging(value);
                ReportPropertyChanging("first_name");
                _first_name = StructuralObject.SetValidValue(value, false, "first_name");
                ReportPropertyChanged("first_name");
                Onfirst_nameChanged();
            }
        }
        private global::System.String _first_name;
        partial void Onfirst_nameChanging(global::System.String value);
        partial void Onfirst_nameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String last_name
        {
            get
            {
                return _last_name;
            }
            set
            {
                Onlast_nameChanging(value);
                ReportPropertyChanging("last_name");
                _last_name = StructuralObject.SetValidValue(value, false, "last_name");
                ReportPropertyChanged("last_name");
                Onlast_nameChanged();
            }
        }
        private global::System.String _last_name;
        partial void Onlast_nameChanging(global::System.String value);
        partial void Onlast_nameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EmployeesModel", "FK__Assignmen__Emplo__3A81B327", "Assignments")]
        public EntityCollection<Assignment> Assignments
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Assignment>("EmployeesModel.FK__Assignmen__Emplo__3A81B327", "Assignments");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Assignment>("EmployeesModel.FK__Assignmen__Emplo__3A81B327", "Assignments", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
