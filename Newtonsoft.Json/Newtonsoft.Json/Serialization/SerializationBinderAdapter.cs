using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009E RID: 158
	public class SerializationBinderAdapter : Object
	{
		// Token: 0x06000D7B RID: 3451 RVA: 0x00050100 File Offset: 0x0004E300
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationBinderAdapter()
		{
			Il2CppClassPointerStore<SerializationBinderAdapter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "SerializationBinderAdapter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationBinderAdapter>.NativeClassPtr);
			SerializationBinderAdapter.NativeFieldInfoPtr_SerializationBinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationBinderAdapter>.NativeClassPtr, "SerializationBinder");
			SerializationBinderAdapter.NativeMethodInfoPtr__ctor_Public_Void_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationBinderAdapter>.NativeClassPtr, 100665748);
			SerializationBinderAdapter.NativeMethodInfoPtr_BindToType_Public_Virtual_Final_New_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationBinderAdapter>.NativeClassPtr, 100665749);
			SerializationBinderAdapter.NativeMethodInfoPtr_BindToName_Public_Virtual_Final_New_Void_Type_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationBinderAdapter>.NativeClassPtr, 100665750);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00050180 File Offset: 0x0004E380
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationBinderAdapter(SerializationBinder serializationBinder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationBinderAdapter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationBinder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationBinderAdapter.NativeMethodInfoPtr__ctor_Public_Void_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x000501CC File Offset: 0x0004E3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753764, XrefRangeEnd = 753765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type BindToType(string assemblyName, string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationBinderAdapter.NativeMethodInfoPtr_BindToType_Public_Virtual_Final_New_Type_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00050230 File Offset: 0x0004E430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753765, XrefRangeEnd = 753766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BindToName(Type serializedType, out string assemblyName, out string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SerializationBinderAdapter.NativeMethodInfoPtr_BindToName_Public_Virtual_Final_New_Void_Type_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			assemblyName = IL2CPP.Il2CppStringToManaged(intPtr);
			typeName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00006644 File Offset: 0x00004844
		public SerializationBinderAdapter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x000502A8 File Offset: 0x0004E4A8
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x0000664D File Offset: 0x0000484D
		public unsafe SerializationBinder SerializationBinder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationBinderAdapter.NativeFieldInfoPtr_SerializationBinder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationBinderAdapter.NativeFieldInfoPtr_SerializationBinder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeFieldInfoPtr_SerializationBinder;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationBinder_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_BindToType_Public_Virtual_Final_New_Type_String_String_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_BindToName_Public_Virtual_Final_New_Void_Type_byref_String_byref_String_0;
	}
}
