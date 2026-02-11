using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings
{
	// Token: 0x020000A6 RID: 166
	public class CalculatedSetting<T> : Object
	{
		// Token: 0x06000B3A RID: 2874 RVA: 0x0003E3B8 File Offset: 0x0003C5B8
		// Note: this type is marked as 'beforefieldinit'.
		static CalculatedSetting()
		{
			Il2CppClassPointerStore<CalculatedSetting<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "CalculatedSetting`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CalculatedSetting<T>>.NativeClassPtr);
			CalculatedSetting<T>.NativeFieldInfoPtr_getter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalculatedSetting<T>>.NativeClassPtr, "getter");
			CalculatedSetting<T>.NativeFieldInfoPtr_versionGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalculatedSetting<T>>.NativeClassPtr, "versionGetter");
			CalculatedSetting<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Func_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalculatedSetting<T>>.NativeClassPtr, 100664862);
			CalculatedSetting<T>.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalculatedSetting<T>>.NativeClassPtr, 100664863);
			CalculatedSetting<T>.NativeMethodInfoPtr_dwd_core_settings_ISetting_T__Get_Private_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalculatedSetting<T>>.NativeClassPtr, 100664864);
			CalculatedSetting<T>.NativeMethodInfoPtr_Canis_utils_IVersionedModel_get_Version_Private_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalculatedSetting<T>>.NativeClassPtr, 100664865);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0003E49C File Offset: 0x0003C69C
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CalculatedSetting(Func<T> getter, Func<ulong> versionGetter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalculatedSetting<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(versionGetter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalculatedSetting<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Func_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0003E4FC File Offset: 0x0003C6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863528, XrefRangeEnd = 863530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object dwd_core_settings_ISetting_Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalculatedSetting<T>.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0003E53C File Offset: 0x0003C73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863530, XrefRangeEnd = 863532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T dwd_core_settings_ISetting_T__Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalculatedSetting<T>.NativeMethodInfoPtr_dwd_core_settings_ISetting_T__Get_Private_Virtual_Final_New_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0003E578 File Offset: 0x0003C778
		public unsafe virtual ulong Canis.utils.IVersionedModel.Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863532, XrefRangeEnd = 863533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CalculatedSetting<T>.NativeMethodInfoPtr_Canis_utils_IVersionedModel_get_Version_Private_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00005FA8 File Offset: 0x000041A8
		public CalculatedSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0003E5B4 File Offset: 0x0003C7B4
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x00005FB1 File Offset: 0x000041B1
		public unsafe Func<T> getter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalculatedSetting<T>.NativeFieldInfoPtr_getter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalculatedSetting<T>.NativeFieldInfoPtr_getter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0003E5E4 File Offset: 0x0003C7E4
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x00005FD0 File Offset: 0x000041D0
		public unsafe Func<ulong> versionGetter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalculatedSetting<T>.NativeFieldInfoPtr_versionGetter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CalculatedSetting<T>.NativeFieldInfoPtr_versionGetter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeFieldInfoPtr_getter;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeFieldInfoPtr_versionGetter;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Func_1_UInt64_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISetting_T__Get_Private_Virtual_Final_New_T_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_Canis_utils_IVersionedModel_get_Version_Private_Virtual_Final_New_get_UInt64_0;
	}
}
