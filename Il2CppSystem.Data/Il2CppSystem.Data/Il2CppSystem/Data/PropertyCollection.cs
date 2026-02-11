using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Data
{
	// Token: 0x0200006B RID: 107
	[Serializable]
	public class PropertyCollection : Hashtable
	{
		// Token: 0x06000A10 RID: 2576 RVA: 0x00034098 File Offset: 0x00032298
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyCollection()
		{
			Il2CppClassPointerStore<PropertyCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "PropertyCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyCollection>.NativeClassPtr);
			PropertyCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyCollection>.NativeClassPtr, 100664946);
			PropertyCollection.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyCollection>.NativeClassPtr, 100664947);
			PropertyCollection.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyCollection>.NativeClassPtr, 100664948);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00034104 File Offset: 0x00032304
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 905616, RefRangeEnd = 905626, XrefRangeStart = 905615, XrefRangeEnd = 905616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00034140 File Offset: 0x00032340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905626, XrefRangeEnd = 905627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyCollection(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyCollection.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x000341A4 File Offset: 0x000323A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905627, XrefRangeEnd = 905648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyCollection.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x000050BE File Offset: 0x000032BE
		public PropertyCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;
	}
}
