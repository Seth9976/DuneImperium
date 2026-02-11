using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Xml
{
	// Token: 0x020000A6 RID: 166
	public class XmlResolver : Object
	{
		// Token: 0x060011D1 RID: 4561 RVA: 0x00064DF8 File Offset: 0x00062FF8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlResolver()
		{
			Il2CppClassPointerStore<XmlResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr);
			XmlResolver.NativeMethodInfoPtr_GetEntity_Public_Abstract_Virtual_New_Object_Uri_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr, 100666250);
			XmlResolver.NativeMethodInfoPtr_ResolveUri_Public_Virtual_New_Uri_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr, 100666251);
			XmlResolver.NativeMethodInfoPtr_SupportsType_Public_Virtual_New_Boolean_Uri_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr, 100666252);
			XmlResolver.NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_New_Task_1_Object_Uri_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr, 100666253);
			XmlResolver.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr, 100666254);
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00064E8C File Offset: 0x0006308C
		[CallerCount(0)]
		public unsafe virtual Object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(absoluteUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(role);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ofObjectToReturn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlResolver.NativeMethodInfoPtr_GetEntity_Public_Abstract_Virtual_New_Object_Uri_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00064F0C File Offset: 0x0006310C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383132, RefRangeEnd = 383133, XrefRangeStart = 383121, XrefRangeEnd = 383132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlResolver.NativeMethodInfoPtr_ResolveUri_Public_Virtual_New_Uri_Uri_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00064F7C File Offset: 0x0006317C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383133, XrefRangeEnd = 383147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SupportsType(Uri absoluteUri, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(absoluteUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlResolver.NativeMethodInfoPtr_SupportsType_Public_Virtual_New_Boolean_Uri_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00064FE8 File Offset: 0x000631E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383147, XrefRangeEnd = 383152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(absoluteUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(role);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ofObjectToReturn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlResolver.NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_New_Task_1_Object_Uri_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Object>>(intPtr3) : null;
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00065068 File Offset: 0x00063268
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlResolver.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00007989 File Offset: 0x00005B89
		public XmlResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr_GetEntity_Public_Abstract_Virtual_New_Object_Uri_String_Type_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr_ResolveUri_Public_Virtual_New_Uri_Uri_String_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_SupportsType_Public_Virtual_New_Boolean_Uri_Type_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_GetEntityAsync_Public_Virtual_New_Task_1_Object_Uri_String_Type_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
