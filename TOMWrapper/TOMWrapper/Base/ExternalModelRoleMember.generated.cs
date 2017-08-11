
// Code generated by a template
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using TabularEditor.PropertyGridUI;
using TabularEditor.UndoFramework;
using System.Drawing.Design;
using TOM = Microsoft.AnalysisServices.Tabular;
namespace TabularEditor.TOMWrapper
{
  
	/// <summary>
///             For internal use only.
///             </summary>
	[TypeConverter(typeof(DynamicPropertyConverter))]
	public partial class ExternalModelRoleMember: ModelRoleMember
			, IClonableObject
	{
	    protected internal new TOM.ExternalModelRoleMember MetadataObject { get { return base.MetadataObject as TOM.ExternalModelRoleMember; } internal set { base.MetadataObject = value; } }

/// <summary>
///             Gets or sets the identity provider.
///             </summary><returns>The identity provider.</returns>
		[DisplayName("Identity Provider")]
		[Category("Other"),Description(@"Gets or sets the identity provider."),IntelliSense("The Identity Provider of this ExternalModelRoleMember.")]
		public string IdentityProvider {
			get {
			    return MetadataObject.IdentityProvider;
			}
			set {
				var oldValue = IdentityProvider;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging(Properties.IDENTITYPROVIDER, value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IdentityProvider = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, Properties.IDENTITYPROVIDER, oldValue, value));
				OnPropertyChanged(Properties.IDENTITYPROVIDER, oldValue, value);
			}
		}
		private bool ShouldSerializeIdentityProvider() { return false; }
/// <summary>Gets or sets the external role for the member type property.</summary><returns>The role member type property.</returns>
		[DisplayName("Member Type")]
		[Category("Other"),Description(@"Gets or sets the external role for the member type property."),IntelliSense("The Member Type of this ExternalModelRoleMember.")]
		public RoleMemberType MemberType {
			get {
			    return (RoleMemberType)MetadataObject.MemberType;
			}
			set {
				var oldValue = MemberType;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging(Properties.MEMBERTYPE, value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.MemberType = (TOM.RoleMemberType)value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, Properties.MEMBERTYPE, oldValue, value));
				OnPropertyChanged(Properties.MEMBERTYPE, oldValue, value);
			}
		}
		private bool ShouldSerializeMemberType() { return false; }


		public static ExternalModelRoleMember CreateFromMetadata(TOM.ExternalModelRoleMember metadataObject, bool init = true) {
			var obj = new ExternalModelRoleMember(metadataObject, init);
			if(init) 
			{
				obj.InternalInit();
				obj.Init();
			}
			return obj;
		}


		/// <summary>
		/// Creates a new ExternalModelRoleMember and adds it to the parent ModelRole.
		/// Also creates the underlying metadataobject and adds it to the TOM tree.
		/// </summary>
		public static ExternalModelRoleMember CreateNew(ModelRole parent, string name = null)
		{
			var metadataObject = new TOM.ExternalModelRoleMember();
			metadataObject.Name = parent.Members.GetNewName(string.IsNullOrWhiteSpace(name) ? "New ExternalModelRoleMember" : name);

			var obj = new ExternalModelRoleMember(metadataObject);

			parent.Members.Add(obj);
			
			obj.Init();

			return obj;
		}


		/// <summary>
		/// Creates an exact copy of this ExternalModelRoleMember object.
		/// </summary>
		public ExternalModelRoleMember Clone(string newName = null, ModelRole newParent = null) {
		    Handler.BeginUpdate("Clone ExternalModelRoleMember");

			// Create a clone of the underlying metadataobject:
			var tom = MetadataObject.Clone() as TOM.ExternalModelRoleMember;


			// Assign a new, unique name:
			tom.Name = Parent.Members.GetNewName(string.IsNullOrEmpty(newName) ? tom.Name + " copy" : newName);
				
			// Create the TOM Wrapper object, representing the metadataobject (but don't init until after we add it to the parent):
			var obj = CreateFromMetadata(tom, false);

			// Add the object to the parent collection:
			if(newParent != null) 
				newParent.Members.Add(obj);
			else
    			Parent.Members.Add(obj);

			obj.InternalInit();
			obj.Init();


            Handler.EndUpdate();

            return obj;
		}

		TabularNamedObject IClonableObject.Clone(string newName, bool includeTranslations, TabularNamedObject newParent) 
		{
			if (includeTranslations) throw new ArgumentException("This object does not support translations", "includeTranslations");
			return Clone(newName);
		}

	
        internal override void RenewMetadataObject()
        {
            Handler.WrapperLookup.Remove(MetadataObject);
            MetadataObject = MetadataObject.Clone() as TOM.ExternalModelRoleMember;
            Handler.WrapperLookup.Add(MetadataObject, this);
        }

		public ModelRole Parent { 
			get {
				return Handler.WrapperLookup[MetadataObject.Parent] as ModelRole;
			}
		}



		/// <summary>
		/// CTOR - only called from static factory methods on the class
		/// </summary>
		protected ExternalModelRoleMember(TOM.ExternalModelRoleMember metadataObject, bool init = true) : base(metadataObject)
		{
			if(init) InternalInit();
		}

		private void InternalInit()
		{
		}



		internal override void Undelete(ITabularObjectCollection collection) {
			base.Undelete(collection);
			Reinit();
			ReapplyReferences();
		}

		public override bool Browsable(string propertyName) {
			switch (propertyName) {
				case Properties.PARENT:
					return false;
				
				default:
					return base.Browsable(propertyName);
			}
		}

    }

}