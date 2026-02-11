using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020002C6 RID: 710
	public class DiagnosticSwitch
	{
		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x000B2E54 File Offset: 0x000B1054
		public string name
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_nameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x000B2E78 File Offset: 0x000B1078
		public string description
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_descriptionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x000B2E9C File Offset: 0x000B109C
		public string owningModule
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_owningModuleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x00011867 File Offset: 0x0000FA67
		public DiagnosticSwitch.Flags flags
		{
			get
			{
				return DiagnosticSwitch.get_flagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x00011879 File Offset: 0x0000FA79
		// (set) Token: 0x06002CE4 RID: 11492 RVA: 0x00011881 File Offset: 0x0000FA81
		public Object value
		{
			get
			{
				return this.GetScriptingValue();
			}
			set
			{
				this.SetScriptingValue(value, false);
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x000B2EC0 File Offset: 0x000B10C0
		public Object defaultValue
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_defaultValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x000B2EEC File Offset: 0x000B10EC
		public Object minValue
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_minValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x000B2F18 File Offset: 0x000B1118
		public Object maxValue
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_maxValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x0001188C File Offset: 0x0000FA8C
		// (set) Token: 0x06002CE9 RID: 11497 RVA: 0x00011894 File Offset: 0x0000FA94
		public Object persistentValue
		{
			get
			{
				return this.GetScriptingPersistentValue();
			}
			set
			{
				this.SetScriptingValue(value, true);
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06002CEA RID: 11498 RVA: 0x000B2F44 File Offset: 0x000B1144
		public EnumInfo enumInfo
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_enumInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumInfo>(intPtr2) : null;
			}
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x000B2F70 File Offset: 0x000B1170
		public Object GetScriptingValue()
		{
			IntPtr intPtr = DiagnosticSwitch.GetScriptingValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x000B2F9C File Offset: 0x000B119C
		public Object GetScriptingPersistentValue()
		{
			IntPtr intPtr = DiagnosticSwitch.GetScriptingPersistentValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x0001189F File Offset: 0x0000FA9F
		public void SetScriptingValue(Object value, bool setPersistent)
		{
			DiagnosticSwitch.SetScriptingValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value), setPersistent);
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06002CEE RID: 11502 RVA: 0x000118B8 File Offset: 0x0000FAB8
		public bool isSetToDefault
		{
			get
			{
				return Object.Equals(this.persistentValue, this.defaultValue);
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x000118CB File Offset: 0x0000FACB
		public bool needsRestart
		{
			get
			{
				return !Object.Equals(this.value, this.persistentValue);
			}
		}

		// Token: 0x04002840 RID: 10304
		private static readonly DiagnosticSwitch.get_nameDelegate get_nameDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_nameDelegate>("UnityEngine.DiagnosticSwitch::get_name");

		// Token: 0x04002841 RID: 10305
		private static readonly DiagnosticSwitch.get_descriptionDelegate get_descriptionDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_descriptionDelegate>("UnityEngine.DiagnosticSwitch::get_description");

		// Token: 0x04002842 RID: 10306
		private static readonly DiagnosticSwitch.get_owningModuleDelegate get_owningModuleDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_owningModuleDelegate>("UnityEngine.DiagnosticSwitch::get_owningModule");

		// Token: 0x04002843 RID: 10307
		private static readonly DiagnosticSwitch.get_flagsDelegate get_flagsDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_flagsDelegate>("UnityEngine.DiagnosticSwitch::get_flags");

		// Token: 0x04002844 RID: 10308
		private static readonly DiagnosticSwitch.get_defaultValueDelegate get_defaultValueDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_defaultValueDelegate>("UnityEngine.DiagnosticSwitch::get_defaultValue");

		// Token: 0x04002845 RID: 10309
		private static readonly DiagnosticSwitch.get_minValueDelegate get_minValueDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_minValueDelegate>("UnityEngine.DiagnosticSwitch::get_minValue");

		// Token: 0x04002846 RID: 10310
		private static readonly DiagnosticSwitch.get_maxValueDelegate get_maxValueDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_maxValueDelegate>("UnityEngine.DiagnosticSwitch::get_maxValue");

		// Token: 0x04002847 RID: 10311
		private static readonly DiagnosticSwitch.get_enumInfoDelegate get_enumInfoDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_enumInfoDelegate>("UnityEngine.DiagnosticSwitch::get_enumInfo");

		// Token: 0x04002848 RID: 10312
		private static readonly DiagnosticSwitch.GetScriptingValueDelegate GetScriptingValueDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.GetScriptingValueDelegate>("UnityEngine.DiagnosticSwitch::GetScriptingValue");

		// Token: 0x04002849 RID: 10313
		private static readonly DiagnosticSwitch.GetScriptingPersistentValueDelegate GetScriptingPersistentValueDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.GetScriptingPersistentValueDelegate>("UnityEngine.DiagnosticSwitch::GetScriptingPersistentValue");

		// Token: 0x0400284A RID: 10314
		private static readonly DiagnosticSwitch.SetScriptingValueDelegate SetScriptingValueDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.SetScriptingValueDelegate>("UnityEngine.DiagnosticSwitch::SetScriptingValue");

		// Token: 0x02000AE5 RID: 2789
		public enum Flags
		{
			// Token: 0x04002DB1 RID: 11697
			None,
			// Token: 0x04002DB2 RID: 11698
			CanChangeAfterEngineStart,
			// Token: 0x04002DB3 RID: 11699
			PropagateToAssetImportWorkerProcess
		}

		// Token: 0x02000AE6 RID: 2790
		// (Invoke) Token: 0x06003EC1 RID: 16065
		private delegate IntPtr get_nameDelegate(IntPtr @this);

		// Token: 0x02000AE7 RID: 2791
		// (Invoke) Token: 0x06003EC3 RID: 16067
		private delegate IntPtr get_descriptionDelegate(IntPtr @this);

		// Token: 0x02000AE8 RID: 2792
		// (Invoke) Token: 0x06003EC5 RID: 16069
		private delegate IntPtr get_owningModuleDelegate(IntPtr @this);

		// Token: 0x02000AE9 RID: 2793
		// (Invoke) Token: 0x06003EC7 RID: 16071
		private delegate DiagnosticSwitch.Flags get_flagsDelegate(IntPtr @this);

		// Token: 0x02000AEA RID: 2794
		// (Invoke) Token: 0x06003EC9 RID: 16073
		private delegate IntPtr get_defaultValueDelegate(IntPtr @this);

		// Token: 0x02000AEB RID: 2795
		// (Invoke) Token: 0x06003ECB RID: 16075
		private delegate IntPtr get_minValueDelegate(IntPtr @this);

		// Token: 0x02000AEC RID: 2796
		// (Invoke) Token: 0x06003ECD RID: 16077
		private delegate IntPtr get_maxValueDelegate(IntPtr @this);

		// Token: 0x02000AED RID: 2797
		// (Invoke) Token: 0x06003ECF RID: 16079
		private delegate IntPtr get_enumInfoDelegate(IntPtr @this);

		// Token: 0x02000AEE RID: 2798
		// (Invoke) Token: 0x06003ED1 RID: 16081
		private delegate IntPtr GetScriptingValueDelegate(IntPtr @this);

		// Token: 0x02000AEF RID: 2799
		// (Invoke) Token: 0x06003ED3 RID: 16083
		private delegate IntPtr GetScriptingPersistentValueDelegate(IntPtr @this);

		// Token: 0x02000AF0 RID: 2800
		// (Invoke) Token: 0x06003ED5 RID: 16085
		private delegate void SetScriptingValueDelegate(IntPtr @this, IntPtr value, bool setPersistent);
	}
}
