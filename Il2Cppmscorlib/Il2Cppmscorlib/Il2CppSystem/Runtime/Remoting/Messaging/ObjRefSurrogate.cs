using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x0200030A RID: 778
	public class ObjRefSurrogate : Object
	{
		// Token: 0x06003006 RID: 12294 RVA: 0x000F5E14 File Offset: 0x000F4014
		// Note: this type is marked as 'beforefieldinit'.
		static ObjRefSurrogate()
		{
			Il2CppClassPointerStore<ObjRefSurrogate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ObjRefSurrogate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjRefSurrogate>.NativeClassPtr);
			ObjRefSurrogate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRefSurrogate>.NativeClassPtr, 100670900);
			ObjRefSurrogate.NativeMethodInfoPtr_SetObjectData_Public_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRefSurrogate>.NativeClassPtr, 100670901);
			ObjRefSurrogate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRefSurrogate>.NativeClassPtr, 100670902);
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x000F5E80 File Offset: 0x000F4080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384219, XrefRangeEnd = 1384230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(Object obj, SerializationInfo si, StreamingContext sc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(si);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRefSurrogate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x000F5EF8 File Offset: 0x000F40F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384230, XrefRangeEnd = 1384236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object SetObjectData(Object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(si);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sc));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRefSurrogate.NativeMethodInfoPtr_SetObjectData_Public_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x000F5F90 File Offset: 0x000F4190
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRefSurrogate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRefSurrogate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRefSurrogate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x000106B1 File Offset: 0x0000E8B1
		public ObjRefSurrogate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040027CB RID: 10187
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x040027CC RID: 10188
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectData_Public_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0;

		// Token: 0x040027CD RID: 10189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
