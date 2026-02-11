using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MS.Internal.Xml.XPath;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000104 RID: 260
	public class DoubleLinkAxis : Axis
	{
		// Token: 0x06001772 RID: 6002 RVA: 0x0007A804 File Offset: 0x00078A04
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleLinkAxis()
		{
			Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "DoubleLinkAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr);
			DoubleLinkAxis.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, "next");
			DoubleLinkAxis.NativeMethodInfoPtr_get_Next_Internal_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, 100666970);
			DoubleLinkAxis.NativeMethodInfoPtr_set_Next_Internal_set_Void_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, 100666971);
			DoubleLinkAxis.NativeMethodInfoPtr__ctor_Internal_Void_Axis_DoubleLinkAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, 100666972);
			DoubleLinkAxis.NativeMethodInfoPtr_ConvertTree_Internal_Static_DoubleLinkAxis_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, 100666973);
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x0007A898 File Offset: 0x00078A98
		// (set) Token: 0x06001774 RID: 6004 RVA: 0x0007A8D8 File Offset: 0x00078AD8
		public unsafe Axis Next
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleLinkAxis.NativeMethodInfoPtr_get_Next_Internal_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Axis>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleLinkAxis.NativeMethodInfoPtr_set_Next_Internal_set_Void_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x0007A91C File Offset: 0x00078B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390736, XrefRangeEnd = 390740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleLinkAxis(Axis axis, DoubleLinkAxis inputaxis)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputaxis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleLinkAxis.NativeMethodInfoPtr__ctor_Internal_Void_Axis_DoubleLinkAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0007A97C File Offset: 0x00078B7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 390750, RefRangeEnd = 390754, XrefRangeStart = 390740, XrefRangeEnd = 390750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DoubleLinkAxis ConvertTree(Axis axis)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleLinkAxis.NativeMethodInfoPtr_ConvertTree_Internal_Static_DoubleLinkAxis_Axis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr3) : null;
			}
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x0000A04A File Offset: 0x0000824A
		public DoubleLinkAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x0007A9C0 File Offset: 0x00078BC0
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x0000A053 File Offset: 0x00008253
		public unsafe Axis next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleLinkAxis.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Axis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoubleLinkAxis.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeMethodInfoPtr_get_Next_Internal_get_Axis_0;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeMethodInfoPtr_set_Next_Internal_set_Void_Axis_0;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Axis_DoubleLinkAxis_0;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTree_Internal_Static_DoubleLinkAxis_Axis_0;
	}
}
