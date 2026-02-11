using System;
using dwd.canis.lib.canis.dbg_client.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.canis.lib.canis.dbg_client.behaviours
{
	// Token: 0x02000066 RID: 102
	public class SelectableActiveDataSetter : MonoBehaviour
	{
		// Token: 0x060003CD RID: 973 RVA: 0x000298A0 File Offset: 0x00027AA0
		// Note: this type is marked as 'beforefieldinit'.
		static SelectableActiveDataSetter()
		{
			Il2CppClassPointerStore<SelectableActiveDataSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.behaviours", "SelectableActiveDataSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectableActiveDataSetter>.NativeClassPtr);
			SelectableActiveDataSetter.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableActiveDataSetter>.NativeClassPtr, "data");
			SelectableActiveDataSetter.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableActiveDataSetter>.NativeClassPtr, "provider");
			SelectableActiveDataSetter.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableActiveDataSetter>.NativeClassPtr, "initialized");
			SelectableActiveDataSetter.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableActiveDataSetter>.NativeClassPtr, 100663886);
			SelectableActiveDataSetter.NativeMethodInfoPtr_Event_SetData_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableActiveDataSetter>.NativeClassPtr, 100663887);
			SelectableActiveDataSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableActiveDataSetter>.NativeClassPtr, 100663888);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00029948 File Offset: 0x00027B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500039, XrefRangeEnd = 500062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableActiveDataSetter.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0002997C File Offset: 0x00027B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500062, XrefRangeEnd = 500086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetData(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableActiveDataSetter.NativeMethodInfoPtr_Event_SetData_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000299BC File Offset: 0x00027BBC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectableActiveDataSetter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectableActiveDataSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableActiveDataSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00003ACA File Offset: 0x00001CCA
		public SelectableActiveDataSetter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x000299F8 File Offset: 0x00027BF8
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00003AD3 File Offset: 0x00001CD3
		public unsafe SelectableActiveData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableActiveDataSetter.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectableActiveData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableActiveDataSetter.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00029A28 File Offset: 0x00027C28
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00003AF2 File Offset: 0x00001CF2
		public unsafe SubscriptionProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableActiveDataSetter.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableActiveDataSetter.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00029A58 File Offset: 0x00027C58
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00003B11 File Offset: 0x00001D11
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableActiveDataSetter.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableActiveDataSetter.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetData_Public_Void_Boolean_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
