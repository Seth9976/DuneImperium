using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000009 RID: 9
	public class ClipperRegistry : Object
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00009064 File Offset: 0x00007264
		// Note: this type is marked as 'beforefieldinit'.
		static ClipperRegistry()
		{
			Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ClipperRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr);
			ClipperRegistry.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, "s_Instance");
			ClipperRegistry.NativeFieldInfoPtr_m_Clippers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, "m_Clippers");
			ClipperRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, 100663371);
			ClipperRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_ClipperRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, 100663372);
			ClipperRegistry.NativeMethodInfoPtr_Cull_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, 100663373);
			ClipperRegistry.NativeMethodInfoPtr_Register_Public_Static_Void_IClipper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, 100663374);
			ClipperRegistry.NativeMethodInfoPtr_Unregister_Public_Static_Void_IClipper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, 100663375);
			ClipperRegistry.NativeMethodInfoPtr_Disable_Public_Static_Void_IClipper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr, 100663376);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00009134 File Offset: 0x00007334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081554, XrefRangeEnd = 1081562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClipperRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00009170 File Offset: 0x00007370
		public unsafe static ClipperRegistry instance
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1081577, RefRangeEnd = 1081581, XrefRangeStart = 1081562, XrefRangeEnd = 1081577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_ClipperRegistry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClipperRegistry>(intPtr3) : null;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000091A4 File Offset: 0x000073A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081581, XrefRangeEnd = 1081588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperRegistry.NativeMethodInfoPtr_Cull_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000091D8 File Offset: 0x000073D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081592, RefRangeEnd = 1081593, XrefRangeStart = 1081588, XrefRangeEnd = 1081592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register(IClipper c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperRegistry.NativeMethodInfoPtr_Register_Public_Static_Void_IClipper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00009210 File Offset: 0x00007410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081598, RefRangeEnd = 1081599, XrefRangeStart = 1081593, XrefRangeEnd = 1081598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Unregister(IClipper c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperRegistry.NativeMethodInfoPtr_Unregister_Public_Static_Void_IClipper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00009248 File Offset: 0x00007448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081604, RefRangeEnd = 1081605, XrefRangeStart = 1081599, XrefRangeEnd = 1081604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Disable(IClipper c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipperRegistry.NativeMethodInfoPtr_Disable_Public_Static_Void_IClipper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000227A File Offset: 0x0000047A
		public ClipperRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00009280 File Offset: 0x00007480
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002283 File Offset: 0x00000483
		public unsafe static ClipperRegistry s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClipperRegistry.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipperRegistry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClipperRegistry.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000092A8 File Offset: 0x000074A8
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002295 File Offset: 0x00000495
		public unsafe IndexedSet<IClipper> m_Clippers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperRegistry.NativeFieldInfoPtr_m_Clippers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedSet<IClipper>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClipperRegistry.NativeFieldInfoPtr_m_Clippers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_m_Clippers;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_ClipperRegistry_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_Cull_Public_Void_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Static_Void_IClipper_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Static_Void_IClipper_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Static_Void_IClipper_0;
	}
}
