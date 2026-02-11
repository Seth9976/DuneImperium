using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Profiling;

namespace UnityEngine.Rendering
{
	// Token: 0x0200007A RID: 122
	public sealed class ProfilingSample : ValueType
	{
		// Token: 0x06000807 RID: 2055 RVA: 0x0002BC00 File Offset: 0x00029E00
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilingSample()
		{
			Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProfilingSample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr);
			ProfilingSample.NativeFieldInfoPtr_m_Cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr, "m_Cmd");
			ProfilingSample.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr, "m_Name");
			ProfilingSample.NativeFieldInfoPtr_m_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr, "m_Disposed");
			ProfilingSample.NativeFieldInfoPtr_m_Sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr, "m_Sampler");
			ProfilingSample.NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_String_CustomSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr, 100664577);
			ProfilingSample.NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr, 100664578);
			ProfilingSample.NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr, 100664579);
			ProfilingSample.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr, 100664580);
			ProfilingSample.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr, 100664581);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0002BCE4 File Offset: 0x00029EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965127, XrefRangeEnd = 965134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilingSample(CommandBuffer cmd, string name, CustomSampler sampler = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sampler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSample.NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_String_CustomSampler_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0002BD58 File Offset: 0x00029F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965134, XrefRangeEnd = 965142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilingSample(CommandBuffer cmd, string format, Object arg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSample.NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0002BDCC File Offset: 0x00029FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965142, XrefRangeEnd = 965150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilingSample(CommandBuffer cmd, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSample.NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_String_Il2CppReferenceArray_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0002BE50 File Offset: 0x0002A050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965150, XrefRangeEnd = 965154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSample.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0002BE88 File Offset: 0x0002A088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965154, XrefRangeEnd = 965158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilingSample.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00005289 File Offset: 0x00003489
		public ProfilingSample(CommandBuffer cmd, string format, params Object[] args)
			: this(cmd, format, new Il2CppReferenceArray<Object>(args))
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00005299 File Offset: 0x00003499
		public ProfilingSample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x000052A2 File Offset: 0x000034A2
		public ProfilingSample()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfilingSample>.NativeClassPtr))
		{
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x0002BECC File Offset: 0x0002A0CC
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x000052B4 File Offset: 0x000034B4
		public unsafe CommandBuffer m_Cmd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSample.NativeFieldInfoPtr_m_Cmd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSample.NativeFieldInfoPtr_m_Cmd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x0002BEFC File Offset: 0x0002A0FC
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x000052D3 File Offset: 0x000034D3
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSample.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSample.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x0002BF24 File Offset: 0x0002A124
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x000052F2 File Offset: 0x000034F2
		public unsafe bool m_Disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSample.NativeFieldInfoPtr_m_Disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSample.NativeFieldInfoPtr_m_Disposed)) = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x0002BF4C File Offset: 0x0002A14C
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x0000530D File Offset: 0x0000350D
		public unsafe CustomSampler m_Sampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSample.NativeFieldInfoPtr_m_Sampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProfilingSample.NativeFieldInfoPtr_m_Sampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_m_Cmd;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr_m_Disposed;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeFieldInfoPtr_m_Sampler;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_String_CustomSampler_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_String_Object_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;
	}
}
