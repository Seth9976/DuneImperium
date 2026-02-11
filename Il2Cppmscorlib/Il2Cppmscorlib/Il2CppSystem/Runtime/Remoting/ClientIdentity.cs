using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000297 RID: 663
	public class ClientIdentity : Identity
	{
		// Token: 0x06002A59 RID: 10841 RVA: 0x000E1338 File Offset: 0x000DF538
		// Note: this type is marked as 'beforefieldinit'.
		static ClientIdentity()
		{
			Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ClientIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr);
			ClientIdentity.NativeFieldInfoPtr__proxyReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, "_proxyReference");
			ClientIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100670191);
			ClientIdentity.NativeMethodInfoPtr_get_ClientProxy_Public_get_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100670192);
			ClientIdentity.NativeMethodInfoPtr_set_ClientProxy_Public_set_Void_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100670193);
			ClientIdentity.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100670194);
			ClientIdentity.NativeMethodInfoPtr_get_TargetUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100670195);
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x000E13E0 File Offset: 0x000DF5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376832, XrefRangeEnd = 1376840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientIdentity(string objectUri, ObjRef objRef)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objRef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_ObjRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06002A5B RID: 10843 RVA: 0x000E1440 File Offset: 0x000DF640
		// (set) Token: 0x06002A5C RID: 10844 RVA: 0x000E1480 File Offset: 0x000DF680
		public unsafe MarshalByRefObject ClientProxy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376840, XrefRangeEnd = 1376843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientIdentity.NativeMethodInfoPtr_get_ClientProxy_Public_get_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1376848, RefRangeEnd = 1376849, XrefRangeStart = 1376843, XrefRangeEnd = 1376848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientIdentity.NativeMethodInfoPtr_set_ClientProxy_Public_set_Void_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x000E14C4 File Offset: 0x000DF6C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ObjRef CreateObjRef(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientIdentity.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x000E1520 File Offset: 0x000DF720
		public unsafe string TargetUri
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1376850, RefRangeEnd = 1376852, XrefRangeStart = 1376849, XrefRangeEnd = 1376850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientIdentity.NativeMethodInfoPtr_get_TargetUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x0000E165 File Offset: 0x0000C365
		public ClientIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x000E1558 File Offset: 0x000DF758
		// (set) Token: 0x06002A61 RID: 10849 RVA: 0x0000E16E File Offset: 0x0000C36E
		public unsafe WeakReference _proxyReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientIdentity.NativeFieldInfoPtr__proxyReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientIdentity.NativeFieldInfoPtr__proxyReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002407 RID: 9223
		private static readonly IntPtr NativeFieldInfoPtr__proxyReference;

		// Token: 0x04002408 RID: 9224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ObjRef_0;

		// Token: 0x04002409 RID: 9225
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientProxy_Public_get_MarshalByRefObject_0;

		// Token: 0x0400240A RID: 9226
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientProxy_Public_set_Void_MarshalByRefObject_0;

		// Token: 0x0400240B RID: 9227
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0;

		// Token: 0x0400240C RID: 9228
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetUri_Public_get_String_0;
	}
}
