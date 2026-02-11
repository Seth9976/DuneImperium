using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200002F RID: 47
	public class ReadContentAsBinaryHelper : Object
	{
		// Token: 0x060002FD RID: 765 RVA: 0x00021D64 File Offset: 0x0001FF64
		// Note: this type is marked as 'beforefieldinit'.
		static ReadContentAsBinaryHelper()
		{
			Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "ReadContentAsBinaryHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr);
			ReadContentAsBinaryHelper.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, "reader");
			ReadContentAsBinaryHelper.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, "state");
			ReadContentAsBinaryHelper.NativeFieldInfoPtr_valueOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, "valueOffset");
			ReadContentAsBinaryHelper.NativeFieldInfoPtr_isEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, "isEnd");
			ReadContentAsBinaryHelper.NativeMethodInfoPtr_Finish_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, 100663709);
			ReadContentAsBinaryHelper.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, 100663710);
			ReadContentAsBinaryHelper.NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadContentAsBinaryHelper>.NativeClassPtr, 100663711);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00021E20 File Offset: 0x00020020
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 364741, RefRangeEnd = 364749, XrefRangeStart = 364739, XrefRangeEnd = 364741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadContentAsBinaryHelper.NativeMethodInfoPtr_Finish_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00021E54 File Offset: 0x00020054
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadContentAsBinaryHelper.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00021E88 File Offset: 0x00020088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364749, XrefRangeEnd = 364750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToNextContentNode(bool moveIfOnContentNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveIfOnContentNode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadContentAsBinaryHelper.NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000318E File Offset: 0x0000138E
		public ReadContentAsBinaryHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00021ED4 File Offset: 0x000200D4
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00003197 File Offset: 0x00001397
		public unsafe XmlReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00021F04 File Offset: 0x00020104
		// (set) Token: 0x06000305 RID: 773 RVA: 0x000031B6 File Offset: 0x000013B6
		public unsafe ReadContentAsBinaryHelper.State state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00021F2C File Offset: 0x0002012C
		// (set) Token: 0x06000307 RID: 775 RVA: 0x000031D1 File Offset: 0x000013D1
		public unsafe int valueOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_valueOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_valueOffset)) = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00021F54 File Offset: 0x00020154
		// (set) Token: 0x06000309 RID: 777 RVA: 0x000031EC File Offset: 0x000013EC
		public unsafe bool isEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_isEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadContentAsBinaryHelper.NativeFieldInfoPtr_isEnd)) = value;
			}
		}

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr_valueOffset;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeFieldInfoPtr_isEnd;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Internal_Void_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0;

		// Token: 0x02000217 RID: 535
		public enum State
		{
			// Token: 0x04002398 RID: 9112
			None,
			// Token: 0x04002399 RID: 9113
			InReadContent,
			// Token: 0x0400239A RID: 9114
			InReadElementContent
		}
	}
}
