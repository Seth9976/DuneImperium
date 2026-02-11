using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.ids
{
	// Token: 0x02000016 RID: 22
	[Serializable]
	public sealed class ActionUndoID : TypedID
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x000085B0 File Offset: 0x000067B0
		// Note: this type is marked as 'beforefieldinit'.
		static ActionUndoID()
		{
			Il2CppClassPointerStore<ActionUndoID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.ids", "ActionUndoID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionUndoID>.NativeClassPtr);
			ActionUndoID.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionUndoID>.NativeClassPtr, "Empty");
			ActionUndoID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionUndoID>.NativeClassPtr, 100663453);
			ActionUndoID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionUndoID>.NativeClassPtr, 100663454);
			ActionUndoID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionUndoID>.NativeClassPtr, 100663455);
			ActionUndoID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionUndoID>.NativeClassPtr, 100663456);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00008644 File Offset: 0x00006844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179695, XrefRangeEnd = 1179700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionUndoID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionUndoID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionUndoID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00008690 File Offset: 0x00006890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179700, XrefRangeEnd = 1179704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionUndoID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionUndoID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionUndoID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000086D8 File Offset: 0x000068D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179704, XrefRangeEnd = 1179709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionUndoID()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionUndoID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionUndoID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00008714 File Offset: 0x00006914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179709, XrefRangeEnd = 1179717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionUndoID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000024D8 File Offset: 0x000006D8
		public ActionUndoID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00008758 File Offset: 0x00006958
		// (set) Token: 0x060000FE RID: 254 RVA: 0x000024E1 File Offset: 0x000006E1
		public unsafe static ActionUndoID Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ActionUndoID.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionUndoID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActionUndoID.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}
