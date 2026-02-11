using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting;

namespace Il2CppSystem
{
	// Token: 0x02000158 RID: 344
	[Serializable]
	public class MarshalByRefObject : Object
	{
		// Token: 0x0600176B RID: 5995 RVA: 0x00095974 File Offset: 0x00093B74
		// Note: this type is marked as 'beforefieldinit'.
		static MarshalByRefObject()
		{
			Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MarshalByRefObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr);
			MarshalByRefObject.NativeFieldInfoPtr__identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, "_identity");
			MarshalByRefObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100667396);
			MarshalByRefObject.NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100667397);
			MarshalByRefObject.NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100667398);
			MarshalByRefObject.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_New_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100667399);
			MarshalByRefObject.NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr, 100667400);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00095A1C File Offset: 0x00093C1C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalByRefObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarshalByRefObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalByRefObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x00095A58 File Offset: 0x00093C58
		// (set) Token: 0x0600176E RID: 5998 RVA: 0x00095A98 File Offset: 0x00093C98
		public unsafe ServerIdentity ObjectIdentity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1346495, RefRangeEnd = 1346496, XrefRangeStart = 1346490, XrefRangeEnd = 1346495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalByRefObject.NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_ServerIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerIdentity>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1346501, RefRangeEnd = 1346503, XrefRangeStart = 1346496, XrefRangeEnd = 1346501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalByRefObject.NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_ServerIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00095ADC File Offset: 0x00093CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346503, XrefRangeEnd = 1346508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ObjRef CreateObjRef(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MarshalByRefObject.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_New_ObjRef_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00095B38 File Offset: 0x00093D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346508, XrefRangeEnd = 1346513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object InitializeLifetimeService()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MarshalByRefObject.NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0000767F File Offset: 0x0000587F
		public MarshalByRefObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x00095B84 File Offset: 0x00093D84
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x00007688 File Offset: 0x00005888
		public unsafe Object _identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalByRefObject.NativeFieldInfoPtr__identity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalByRefObject.NativeFieldInfoPtr__identity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeFieldInfoPtr__identity;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_ServerIdentity_0;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_ServerIdentity_0;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjRef_Public_Virtual_New_ObjRef_Type_0;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr_InitializeLifetimeService_Public_Virtual_New_Object_0;
	}
}
