using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000324 RID: 804
	public sealed class SerializationObjectManager : Object
	{
		// Token: 0x060030FB RID: 12539 RVA: 0x000F9468 File Offset: 0x000F7668
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationObjectManager()
		{
			Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationObjectManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr);
			SerializationObjectManager.NativeFieldInfoPtr__objectSeenTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, "_objectSeenTable");
			SerializationObjectManager.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, "_context");
			SerializationObjectManager.NativeFieldInfoPtr__onSerializedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, "_onSerializedHandler");
			SerializationObjectManager.NativeMethodInfoPtr__ctor_Public_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, 100671007);
			SerializationObjectManager.NativeMethodInfoPtr_RegisterObject_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, 100671008);
			SerializationObjectManager.NativeMethodInfoPtr_RaiseOnSerializedEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, 100671009);
			SerializationObjectManager.NativeMethodInfoPtr_AddOnSerialized_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr, 100671010);
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x000F9524 File Offset: 0x000F7724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1384810, RefRangeEnd = 1384811, XrefRangeStart = 1384801, XrefRangeEnd = 1384810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationObjectManager(StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationObjectManager>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationObjectManager.NativeMethodInfoPtr__ctor_Public_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x000F9574 File Offset: 0x000F7774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1384830, RefRangeEnd = 1384831, XrefRangeStart = 1384811, XrefRangeEnd = 1384830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObject(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationObjectManager.NativeMethodInfoPtr_RegisterObject_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x000F95B8 File Offset: 0x000F77B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1384831, RefRangeEnd = 1384832, XrefRangeStart = 1384831, XrefRangeEnd = 1384831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseOnSerializedEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationObjectManager.NativeMethodInfoPtr_RaiseOnSerializedEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x000F95EC File Offset: 0x000F77EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384832, XrefRangeEnd = 1384840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOnSerialized(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationObjectManager.NativeMethodInfoPtr_AddOnSerialized_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x00010DC5 File Offset: 0x0000EFC5
		public SerializationObjectManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06003101 RID: 12545 RVA: 0x000F9630 File Offset: 0x000F7830
		// (set) Token: 0x06003102 RID: 12546 RVA: 0x00010DCE File Offset: 0x0000EFCE
		public unsafe Dictionary<Object, Object> _objectSeenTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr__objectSeenTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr__objectSeenTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x000F9660 File Offset: 0x000F7860
		// (set) Token: 0x06003104 RID: 12548 RVA: 0x00010DED File Offset: 0x0000EFED
		public StreamingContext _context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr__context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr__context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x000F9690 File Offset: 0x000F7890
		// (set) Token: 0x06003106 RID: 12550 RVA: 0x00010E1B File Offset: 0x0000F01B
		public unsafe SerializationEventHandler _onSerializedHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr__onSerializedHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationObjectManager.NativeFieldInfoPtr__onSerializedHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400285A RID: 10330
		private static readonly IntPtr NativeFieldInfoPtr__objectSeenTable;

		// Token: 0x0400285B RID: 10331
		private static readonly IntPtr NativeFieldInfoPtr__context;

		// Token: 0x0400285C RID: 10332
		private static readonly IntPtr NativeFieldInfoPtr__onSerializedHandler;

		// Token: 0x0400285D RID: 10333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StreamingContext_0;

		// Token: 0x0400285E RID: 10334
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Public_Void_Object_0;

		// Token: 0x0400285F RID: 10335
		private static readonly IntPtr NativeMethodInfoPtr_RaiseOnSerializedEvent_Public_Void_0;

		// Token: 0x04002860 RID: 10336
		private static readonly IntPtr NativeMethodInfoPtr_AddOnSerialized_Private_Void_Object_0;
	}
}
