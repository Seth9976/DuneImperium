using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting.Proxies
{
	// Token: 0x020002AF RID: 687
	public class TransparentProxy : Object
	{
		// Token: 0x06002BDE RID: 11230 RVA: 0x000E7128 File Offset: 0x000E5328
		// Note: this type is marked as 'beforefieldinit'.
		static TransparentProxy()
		{
			Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Proxies", "TransparentProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr);
			TransparentProxy.NativeFieldInfoPtr__rp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, "_rp");
			TransparentProxy.NativeFieldInfoPtr__class = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, "_class");
			TransparentProxy.NativeFieldInfoPtr__custom_type_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, "_custom_type_info");
			TransparentProxy.NativeMethodInfoPtr_GetProxyType_Internal_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670389);
			TransparentProxy.NativeMethodInfoPtr_get_IsContextBoundObject_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670390);
			TransparentProxy.NativeMethodInfoPtr_get_TargetContext_Private_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670391);
			TransparentProxy.NativeMethodInfoPtr_InCurrentContext_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670392);
			TransparentProxy.NativeMethodInfoPtr_LoadRemoteFieldNew_Internal_Object_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670393);
			TransparentProxy.NativeMethodInfoPtr_StoreRemoteField_Internal_Void_IntPtr_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670394);
			TransparentProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr, 100670395);
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x000E7220 File Offset: 0x000E5420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379711, XrefRangeEnd = 1379719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType GetProxyType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_GetProxyType_Internal_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x000E7260 File Offset: 0x000E5460
		public unsafe bool IsContextBoundObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379719, XrefRangeEnd = 1379728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_get_IsContextBoundObject_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06002BE1 RID: 11233 RVA: 0x000E729C File Offset: 0x000E549C
		public unsafe Context TargetContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_get_TargetContext_Private_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000E72DC File Offset: 0x000E54DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1379737, RefRangeEnd = 1379739, XrefRangeStart = 1379728, XrefRangeEnd = 1379737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InCurrentContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_InCurrentContext_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x000E7318 File Offset: 0x000E5518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379739, XrefRangeEnd = 1379768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref classPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_LoadRemoteFieldNew_Internal_Object_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000E7374 File Offset: 0x000E5574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379768, XrefRangeEnd = 1379799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, Object arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref classPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr_StoreRemoteField_Internal_Void_IntPtr_IntPtr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x000E73D4 File Offset: 0x000E55D4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransparentProxy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransparentProxy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x0000EA06 File Offset: 0x0000CC06
		public TransparentProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06002BE7 RID: 11239 RVA: 0x000E7410 File Offset: 0x000E5610
		// (set) Token: 0x06002BE8 RID: 11240 RVA: 0x0000EA0F File Offset: 0x0000CC0F
		public unsafe RealProxy _rp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__rp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RealProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__rp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06002BE9 RID: 11241 RVA: 0x000E7440 File Offset: 0x000E5640
		// (set) Token: 0x06002BEA RID: 11242 RVA: 0x0000EA2E File Offset: 0x0000CC2E
		public unsafe RuntimeRemoteClassHandle _class
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__class);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__class)) = value;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06002BEB RID: 11243 RVA: 0x000E7468 File Offset: 0x000E5668
		// (set) Token: 0x06002BEC RID: 11244 RVA: 0x0000EA49 File Offset: 0x0000CC49
		public unsafe bool _custom_type_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__custom_type_info);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentProxy.NativeFieldInfoPtr__custom_type_info)) = value;
			}
		}

		// Token: 0x04002514 RID: 9492
		private static readonly IntPtr NativeFieldInfoPtr__rp;

		// Token: 0x04002515 RID: 9493
		private static readonly IntPtr NativeFieldInfoPtr__class;

		// Token: 0x04002516 RID: 9494
		private static readonly IntPtr NativeFieldInfoPtr__custom_type_info;

		// Token: 0x04002517 RID: 9495
		private static readonly IntPtr NativeMethodInfoPtr_GetProxyType_Internal_RuntimeType_0;

		// Token: 0x04002518 RID: 9496
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContextBoundObject_Private_get_Boolean_0;

		// Token: 0x04002519 RID: 9497
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetContext_Private_get_Context_0;

		// Token: 0x0400251A RID: 9498
		private static readonly IntPtr NativeMethodInfoPtr_InCurrentContext_Private_Boolean_0;

		// Token: 0x0400251B RID: 9499
		private static readonly IntPtr NativeMethodInfoPtr_LoadRemoteFieldNew_Internal_Object_IntPtr_IntPtr_0;

		// Token: 0x0400251C RID: 9500
		private static readonly IntPtr NativeMethodInfoPtr_StoreRemoteField_Internal_Void_IntPtr_IntPtr_Object_0;

		// Token: 0x0400251D RID: 9501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
