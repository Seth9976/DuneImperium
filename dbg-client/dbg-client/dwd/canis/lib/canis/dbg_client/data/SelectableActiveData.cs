using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.canis.lib.canis.dbg_client.data
{
	// Token: 0x02000060 RID: 96
	public class SelectableActiveData : VersionedDataComponent
	{
		// Token: 0x060003A4 RID: 932 RVA: 0x00029130 File Offset: 0x00027330
		// Note: this type is marked as 'beforefieldinit'.
		static SelectableActiveData()
		{
			Il2CppClassPointerStore<SelectableActiveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.data", "SelectableActiveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectableActiveData>.NativeClassPtr);
			SelectableActiveData.NativeFieldInfoPtr_selectableActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableActiveData>.NativeClassPtr, "selectableActive");
			SelectableActiveData.NativeMethodInfoPtr_get_SelectableActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableActiveData>.NativeClassPtr, 100663860);
			SelectableActiveData.NativeMethodInfoPtr_set_SelectableActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableActiveData>.NativeClassPtr, 100663861);
			SelectableActiveData.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableActiveData>.NativeClassPtr, 100663862);
			SelectableActiveData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableActiveData>.NativeClassPtr, 100663863);
			SelectableActiveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableActiveData>.NativeClassPtr, 100663864);
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x000291D8 File Offset: 0x000273D8
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00029214 File Offset: 0x00027414
		public unsafe bool SelectableActive
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableActiveData.NativeMethodInfoPtr_get_SelectableActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 499927, RefRangeEnd = 499930, XrefRangeStart = 499926, XrefRangeEnd = 499927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableActiveData.NativeMethodInfoPtr_set_SelectableActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00029254 File Offset: 0x00027454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499930, XrefRangeEnd = 499935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComponent Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectableActiveData.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000292A0 File Offset: 0x000274A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499935, XrefRangeEnd = 499943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectableActiveData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000292E4 File Offset: 0x000274E4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 499944, RefRangeEnd = 499953, XrefRangeStart = 499943, XrefRangeEnd = 499944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectableActiveData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectableActiveData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableActiveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00003982 File Offset: 0x00001B82
		public SelectableActiveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00029320 File Offset: 0x00027520
		// (set) Token: 0x060003AC RID: 940 RVA: 0x0000398B File Offset: 0x00001B8B
		public unsafe bool selectableActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableActiveData.NativeFieldInfoPtr_selectableActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableActiveData.NativeFieldInfoPtr_selectableActive)) = value;
			}
		}

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_selectableActive;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectableActive_Public_get_Boolean_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectableActive_Public_set_Void_Boolean_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
