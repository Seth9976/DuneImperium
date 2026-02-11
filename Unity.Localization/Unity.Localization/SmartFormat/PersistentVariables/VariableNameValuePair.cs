using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000057 RID: 87
	[Serializable]
	public class VariableNameValuePair : Object
	{
		// Token: 0x0600046A RID: 1130 RVA: 0x0001A0FC File Offset: 0x000182FC
		// Note: this type is marked as 'beforefieldinit'.
		static VariableNameValuePair()
		{
			Il2CppClassPointerStore<VariableNameValuePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "VariableNameValuePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableNameValuePair>.NativeClassPtr);
			VariableNameValuePair.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableNameValuePair>.NativeClassPtr, "name");
			VariableNameValuePair.NativeFieldInfoPtr_variable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableNameValuePair>.NativeClassPtr, "variable");
			VariableNameValuePair.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableNameValuePair>.NativeClassPtr, 100664121);
			VariableNameValuePair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableNameValuePair>.NativeClassPtr, 100664122);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0001A17C File Offset: 0x0001837C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071200, XrefRangeEnd = 1071206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VariableNameValuePair.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0001A1C0 File Offset: 0x000183C0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableNameValuePair()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableNameValuePair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableNameValuePair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00003B2B File Offset: 0x00001D2B
		public VariableNameValuePair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0001A1FC File Offset: 0x000183FC
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00003B34 File Offset: 0x00001D34
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableNameValuePair.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableNameValuePair.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0001A224 File Offset: 0x00018424
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00003B53 File Offset: 0x00001D53
		public unsafe IVariable variable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableNameValuePair.NativeFieldInfoPtr_variable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVariable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableNameValuePair.NativeFieldInfoPtr_variable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeFieldInfoPtr_variable;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
