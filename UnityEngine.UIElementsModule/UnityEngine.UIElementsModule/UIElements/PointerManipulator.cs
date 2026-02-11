using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000165 RID: 357
	public class PointerManipulator : MouseManipulator
	{
		// Token: 0x06001A67 RID: 6759 RVA: 0x0007A6F0 File Offset: 0x000788F0
		// Note: this type is marked as 'beforefieldinit'.
		static PointerManipulator()
		{
			Il2CppClassPointerStore<PointerManipulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerManipulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerManipulator>.NativeClassPtr);
			PointerManipulator.NativeFieldInfoPtr_m_CurrentPointerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerManipulator>.NativeClassPtr, "m_CurrentPointerId");
			PointerManipulator.NativeMethodInfoPtr_CanStartManipulation_Protected_Boolean_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerManipulator>.NativeClassPtr, 100667154);
			PointerManipulator.NativeMethodInfoPtr_CanStopManipulation_Protected_Boolean_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerManipulator>.NativeClassPtr, 100667155);
			PointerManipulator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerManipulator>.NativeClassPtr, 100667156);
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x0007A770 File Offset: 0x00078970
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 322054, RefRangeEnd = 322058, XrefRangeStart = 322034, XrefRangeEnd = 322054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartManipulation(IPointerEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerManipulator.NativeMethodInfoPtr_CanStartManipulation_Protected_Boolean_IPointerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x0007A7C0 File Offset: 0x000789C0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 322061, RefRangeEnd = 322069, XrefRangeStart = 322058, XrefRangeEnd = 322061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStopManipulation(IPointerEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerManipulator.NativeMethodInfoPtr_CanStopManipulation_Protected_Boolean_IPointerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0007A810 File Offset: 0x00078A10
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 322070, RefRangeEnd = 322080, XrefRangeStart = 322069, XrefRangeEnd = 322070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerManipulator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerManipulator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerManipulator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0000BFD7 File Offset: 0x0000A1D7
		public PointerManipulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x0007A84C File Offset: 0x00078A4C
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x0000BFE0 File Offset: 0x0000A1E0
		public unsafe int m_CurrentPointerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerManipulator.NativeFieldInfoPtr_m_CurrentPointerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerManipulator.NativeFieldInfoPtr_m_CurrentPointerId)) = value;
			}
		}

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPointerId;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_CanStartManipulation_Protected_Boolean_IPointerEvent_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_CanStopManipulation_Protected_Boolean_IPointerEvent_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
