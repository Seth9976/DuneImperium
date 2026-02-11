using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001E7 RID: 487
	public class IdRefNode : Object
	{
		// Token: 0x0600286B RID: 10347 RVA: 0x000BBD1C File Offset: 0x000B9F1C
		// Note: this type is marked as 'beforefieldinit'.
		static IdRefNode()
		{
			Il2CppClassPointerStore<IdRefNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "IdRefNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr);
			IdRefNode.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr, "Id");
			IdRefNode.NativeFieldInfoPtr_LineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr, "LineNo");
			IdRefNode.NativeFieldInfoPtr_LinePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr, "LinePos");
			IdRefNode.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr, "Next");
			IdRefNode.NativeMethodInfoPtr__ctor_Internal_Void_IdRefNode_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr, 100669138);
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x000BBDB0 File Offset: 0x000B9FB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 415008, RefRangeEnd = 415011, XrefRangeStart = 415005, XrefRangeEnd = 415008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IdRefNode(IdRefNode next, string id, int lineNo, int linePos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdRefNode.NativeMethodInfoPtr__ctor_Internal_Void_IdRefNode_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x00011176 File Offset: 0x0000F376
		public IdRefNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x0600286E RID: 10350 RVA: 0x000BBE2C File Offset: 0x000BA02C
		// (set) Token: 0x0600286F RID: 10351 RVA: 0x0001117F File Offset: 0x0000F37F
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06002870 RID: 10352 RVA: 0x000BBE54 File Offset: 0x000BA054
		// (set) Token: 0x06002871 RID: 10353 RVA: 0x0001119E File Offset: 0x0000F39E
		public unsafe int LineNo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_LineNo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_LineNo)) = value;
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06002872 RID: 10354 RVA: 0x000BBE7C File Offset: 0x000BA07C
		// (set) Token: 0x06002873 RID: 10355 RVA: 0x000111B9 File Offset: 0x0000F3B9
		public unsafe int LinePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_LinePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_LinePos)) = value;
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x000BBEA4 File Offset: 0x000BA0A4
		// (set) Token: 0x06002875 RID: 10357 RVA: 0x000111D4 File Offset: 0x0000F3D4
		public unsafe IdRefNode Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_Next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdRefNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeFieldInfoPtr_LineNo;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeFieldInfoPtr_LinePos;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeFieldInfoPtr_Next;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IdRefNode_String_Int32_Int32_0;
	}
}
