using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000063 RID: 99
	[StructLayout(2)]
	public struct SortingLayer
	{
		// Token: 0x06000321 RID: 801 RVA: 0x0001ECDC File Offset: 0x0001CEDC
		// Note: this type is marked as 'beforefieldinit'.
		static SortingLayer()
		{
			Il2CppClassPointerStore<SortingLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SortingLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr);
			SortingLayer.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, "m_Id");
			SortingLayer.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663589);
			SortingLayer.NativeMethodInfoPtr_get_value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663590);
			SortingLayer.NativeMethodInfoPtr_get_layers_Public_Static_get_Il2CppStructArray_1_SortingLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663591);
			SortingLayer.NativeMethodInfoPtr_GetSortingLayerIDsInternal_Private_Static_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663592);
			SortingLayer.NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663593);
			SortingLayer.NativeMethodInfoPtr_IDToName_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663594);
			SortingLayer.GetLayerValueFromNameDelegateField = IL2CPP.ResolveICall<SortingLayer.GetLayerValueFromNameDelegate>("UnityEngine.SortingLayer::GetLayerValueFromName");
			SortingLayer.NameToIDDelegateField = IL2CPP.ResolveICall<SortingLayer.NameToIDDelegate>("UnityEngine.SortingLayer::NameToID");
			SortingLayer.IsValidDelegateField = IL2CPP.ResolveICall<SortingLayer.IsValidDelegate>("UnityEngine.SortingLayer::IsValid");
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0001EDC8 File Offset: 0x0001CFC8
		public unsafe int id
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_get_id_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0001EDF8 File Offset: 0x0001CFF8
		public unsafe int value
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 644286, RefRangeEnd = 644292, XrefRangeStart = 644284, XrefRangeEnd = 644286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_get_value_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0001EE28 File Offset: 0x0001D028
		public unsafe static Il2CppStructArray<SortingLayer> layers
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 644298, RefRangeEnd = 644305, XrefRangeStart = 644292, XrefRangeEnd = 644298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_get_layers_Public_Static_get_Il2CppStructArray_1_SortingLayer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SortingLayer>>(intPtr3) : null;
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0001EE5C File Offset: 0x0001D05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644305, XrefRangeEnd = 644307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> GetSortingLayerIDsInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_GetSortingLayerIDsInternal_Private_Static_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0001EE90 File Offset: 0x0001D090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 644309, RefRangeEnd = 644311, XrefRangeStart = 644307, XrefRangeEnd = 644309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLayerValueFromID(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0001EED0 File Offset: 0x0001D0D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644313, RefRangeEnd = 644314, XrefRangeStart = 644311, XrefRangeEnd = 644313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IDToName(int id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingLayer.NativeMethodInfoPtr_IDToName_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00003A60 File Offset: 0x00001C60
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, ref this));
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0001EF08 File Offset: 0x0001D108
		public string name
		{
			get
			{
				return SortingLayer.IDToName(this.m_Id);
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00003A72 File Offset: 0x00001C72
		public static int GetLayerValueFromName(string name)
		{
			return SortingLayer.GetLayerValueFromNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00003A84 File Offset: 0x00001C84
		public static int NameToID(string name)
		{
			return SortingLayer.NameToIDDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00003A96 File Offset: 0x00001C96
		public static bool IsValid(int id)
		{
			return SortingLayer.IsValidDelegateField(id);
		}

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Int32_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_get_layers_Public_Static_get_Il2CppStructArray_1_SortingLayer_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingLayerIDsInternal_Private_Static_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_IDToName_Public_Static_String_Int32_0;

		// Token: 0x04000257 RID: 599
		[FieldOffset(0)]
		public int m_Id;

		// Token: 0x04000258 RID: 600
		private static readonly SortingLayer.GetLayerValueFromNameDelegate GetLayerValueFromNameDelegateField;

		// Token: 0x04000259 RID: 601
		private static readonly SortingLayer.NameToIDDelegate NameToIDDelegateField;

		// Token: 0x0400025A RID: 602
		private static readonly SortingLayer.IsValidDelegate IsValidDelegateField;

		// Token: 0x020003FD RID: 1021
		// (Invoke) Token: 0x060030E9 RID: 12521
		private delegate int GetLayerValueFromNameDelegate(IntPtr name);

		// Token: 0x020003FE RID: 1022
		// (Invoke) Token: 0x060030EB RID: 12523
		private delegate int NameToIDDelegate(IntPtr name);

		// Token: 0x020003FF RID: 1023
		// (Invoke) Token: 0x060030ED RID: 12525
		private delegate bool IsValidDelegate(int id);
	}
}
