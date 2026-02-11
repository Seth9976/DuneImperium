using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x02000127 RID: 295
	public sealed class RenderTargetBufferSystem : Object
	{
		// Token: 0x060019D2 RID: 6610 RVA: 0x0006C2D4 File Offset: 0x0006A4D4
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTargetBufferSystem()
		{
			Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "RenderTargetBufferSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr);
			RenderTargetBufferSystem.NativeFieldInfoPtr_m_A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "m_A");
			RenderTargetBufferSystem.NativeFieldInfoPtr_m_B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "m_B");
			RenderTargetBufferSystem.NativeFieldInfoPtr_m_AisBackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "m_AisBackBuffer");
			RenderTargetBufferSystem.NativeFieldInfoPtr_m_Desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "m_Desc");
			RenderTargetBufferSystem.NativeFieldInfoPtr_m_FilterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "m_FilterMode");
			RenderTargetBufferSystem.NativeFieldInfoPtr_m_AllowMSAA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "m_AllowMSAA");
			RenderTargetBufferSystem.NativeMethodInfoPtr_get_backBuffer_Private_get_byref_SwapBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666328);
			RenderTargetBufferSystem.NativeMethodInfoPtr_get_frontBuffer_Private_get_byref_SwapBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666329);
			RenderTargetBufferSystem.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666330);
			RenderTargetBufferSystem.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666331);
			RenderTargetBufferSystem.NativeMethodInfoPtr_PeekBackBuffer_Public_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666332);
			RenderTargetBufferSystem.NativeMethodInfoPtr_GetBackBuffer_Public_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666333);
			RenderTargetBufferSystem.NativeMethodInfoPtr_GetFrontBuffer_Public_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666334);
			RenderTargetBufferSystem.NativeMethodInfoPtr_Swap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666335);
			RenderTargetBufferSystem.NativeMethodInfoPtr_ReAllocate_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666336);
			RenderTargetBufferSystem.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666337);
			RenderTargetBufferSystem.NativeMethodInfoPtr_SetCameraSettings_Public_Void_RenderTextureDescriptor_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666338);
			RenderTargetBufferSystem.NativeMethodInfoPtr_GetBufferA_Public_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666339);
			RenderTargetBufferSystem.NativeMethodInfoPtr_EnableMSAA_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, 100666340);
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x0006C480 File Offset: 0x0006A680
		public unsafe ref RenderTargetBufferSystem.SwapBuffer backBuffer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628857, XrefRangeEnd = 628861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBufferSystem.NativeMethodInfoPtr_get_backBuffer_Private_get_byref_SwapBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x0006C4B4 File Offset: 0x0006A6B4
		public unsafe ref RenderTargetBufferSystem.SwapBuffer frontBuffer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 628861, XrefRangeEnd = 628865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBufferSystem.NativeMethodInfoPtr_get_frontBuffer_Private_get_byref_SwapBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0006C4E8 File Offset: 0x0006A6E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628874, RefRangeEnd = 628876, XrefRangeStart = 628865, XrefRangeEnd = 628874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetBufferSystem(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBufferSystem.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x0006C534 File Offset: 0x0006A734
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 628880, RefRangeEnd = 628884, XrefRangeStart = 628876, XrefRangeEnd = 628880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBufferSystem.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0006C568 File Offset: 0x0006A768
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 628892, RefRangeEnd = 628897, XrefRangeStart = 628884, XrefRangeEnd = 628892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle PeekBackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBufferSystem.NativeMethodInfoPtr_PeekBackBuffer_Public_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0006C5A8 File Offset: 0x0006A7A8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 628906, RefRangeEnd = 628915, XrefRangeStart = 628897, XrefRangeEnd = 628906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle GetBackBuffer(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBufferSystem.NativeMethodInfoPtr_GetBackBuffer_Public_RTHandle_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x0006C5F8 File Offset: 0x0006A7F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628937, RefRangeEnd = 628939, XrefRangeStart = 628915, XrefRangeEnd = 628937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle GetFrontBuffer(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBufferSystem.NativeMethodInfoPtr_GetFrontBuffer_Public_RTHandle_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x0006C648 File Offset: 0x0006A848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628943, RefRangeEnd = 628945, XrefRangeStart = 628939, XrefRangeEnd = 628943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Swap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBufferSystem.NativeMethodInfoPtr_Swap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x0006C67C File Offset: 0x0006A87C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628964, RefRangeEnd = 628966, XrefRangeStart = 628945, XrefRangeEnd = 628964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReAllocate(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBufferSystem.NativeMethodInfoPtr_ReAllocate_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0006C6C0 File Offset: 0x0006A8C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 628970, RefRangeEnd = 628971, XrefRangeStart = 628966, XrefRangeEnd = 628970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBufferSystem.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0006C6F4 File Offset: 0x0006A8F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628984, RefRangeEnd = 628986, XrefRangeStart = 628971, XrefRangeEnd = 628984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraSettings(RenderTextureDescriptor desc, FilterMode filterMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBufferSystem.NativeMethodInfoPtr_SetCameraSettings_Public_Void_RenderTextureDescriptor_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0006C740 File Offset: 0x0006A940
		[CallerCount(0)]
		public unsafe RTHandle GetBufferA()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBufferSystem.NativeMethodInfoPtr_GetBufferA_Public_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0006C780 File Offset: 0x0006A980
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 628991, RefRangeEnd = 628993, XrefRangeStart = 628986, XrefRangeEnd = 628991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableMSAA(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBufferSystem.NativeMethodInfoPtr_EnableMSAA_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0000EA03 File Offset: 0x0000CC03
		public RenderTargetBufferSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x0006C7C0 File Offset: 0x0006A9C0
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x0000EA0C File Offset: 0x0000CC0C
		public RenderTargetBufferSystem.SwapBuffer m_A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.NativeFieldInfoPtr_m_A);
				return new RenderTargetBufferSystem.SwapBuffer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetBufferSystem.SwapBuffer>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.NativeFieldInfoPtr_m_A), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTargetBufferSystem.SwapBuffer>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x0006C7F0 File Offset: 0x0006A9F0
		// (set) Token: 0x060019E4 RID: 6628 RVA: 0x0000EA3A File Offset: 0x0000CC3A
		public RenderTargetBufferSystem.SwapBuffer m_B
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.NativeFieldInfoPtr_m_B);
				return new RenderTargetBufferSystem.SwapBuffer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetBufferSystem.SwapBuffer>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.NativeFieldInfoPtr_m_B), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTargetBufferSystem.SwapBuffer>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x0006C820 File Offset: 0x0006AA20
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x0000EA68 File Offset: 0x0000CC68
		public unsafe static bool m_AisBackBuffer
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(RenderTargetBufferSystem.NativeFieldInfoPtr_m_AisBackBuffer, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderTargetBufferSystem.NativeFieldInfoPtr_m_AisBackBuffer, (void*)(&value));
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x0006C83C File Offset: 0x0006AA3C
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x0000EA76 File Offset: 0x0000CC76
		public unsafe static RenderTextureDescriptor m_Desc
		{
			get
			{
				RenderTextureDescriptor renderTextureDescriptor;
				IL2CPP.il2cpp_field_static_get_value(RenderTargetBufferSystem.NativeFieldInfoPtr_m_Desc, (void*)(&renderTextureDescriptor));
				return renderTextureDescriptor;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderTargetBufferSystem.NativeFieldInfoPtr_m_Desc, (void*)(&value));
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x0006C858 File Offset: 0x0006AA58
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x0000EA84 File Offset: 0x0000CC84
		public unsafe FilterMode m_FilterMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.NativeFieldInfoPtr_m_FilterMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.NativeFieldInfoPtr_m_FilterMode)) = value;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x0006C880 File Offset: 0x0006AA80
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x0000EA9F File Offset: 0x0000CC9F
		public unsafe bool m_AllowMSAA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.NativeFieldInfoPtr_m_AllowMSAA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.NativeFieldInfoPtr_m_AllowMSAA)) = value;
			}
		}

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeFieldInfoPtr_m_A;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeFieldInfoPtr_m_B;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeFieldInfoPtr_m_AisBackBuffer;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeFieldInfoPtr_m_Desc;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeFieldInfoPtr_m_FilterMode;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowMSAA;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_get_backBuffer_Private_get_byref_SwapBuffer_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr_get_frontBuffer_Private_get_byref_SwapBuffer_0;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeMethodInfoPtr_PeekBackBuffer_Public_RTHandle_0;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeMethodInfoPtr_GetBackBuffer_Public_RTHandle_CommandBuffer_0;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeMethodInfoPtr_GetFrontBuffer_Public_RTHandle_CommandBuffer_0;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Public_Void_0;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeMethodInfoPtr_ReAllocate_Private_Void_CommandBuffer_0;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraSettings_Public_Void_RenderTextureDescriptor_FilterMode_0;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeMethodInfoPtr_GetBufferA_Public_RTHandle_0;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeMethodInfoPtr_EnableMSAA_Public_Void_Boolean_0;

		// Token: 0x02000205 RID: 517
		public sealed class SwapBuffer : ValueType
		{
			// Token: 0x06002393 RID: 9107 RVA: 0x00085EE8 File Offset: 0x000840E8
			// Note: this type is marked as 'beforefieldinit'.
			static SwapBuffer()
			{
				Il2CppClassPointerStore<RenderTargetBufferSystem.SwapBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderTargetBufferSystem>.NativeClassPtr, "SwapBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetBufferSystem.SwapBuffer>.NativeClassPtr);
				RenderTargetBufferSystem.SwapBuffer.NativeFieldInfoPtr_rtMSAA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem.SwapBuffer>.NativeClassPtr, "rtMSAA");
				RenderTargetBufferSystem.SwapBuffer.NativeFieldInfoPtr_rtResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem.SwapBuffer>.NativeClassPtr, "rtResolve");
				RenderTargetBufferSystem.SwapBuffer.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem.SwapBuffer>.NativeClassPtr, "name");
				RenderTargetBufferSystem.SwapBuffer.NativeFieldInfoPtr_msaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBufferSystem.SwapBuffer>.NativeClassPtr, "msaa");
			}

			// Token: 0x06002394 RID: 9108 RVA: 0x00014602 File Offset: 0x00012802
			public SwapBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002395 RID: 9109 RVA: 0x0001460B File Offset: 0x0001280B
			public SwapBuffer()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTargetBufferSystem.SwapBuffer>.NativeClassPtr))
			{
			}

			// Token: 0x17000CDC RID: 3292
			// (get) Token: 0x06002396 RID: 9110 RVA: 0x00085F64 File Offset: 0x00084164
			// (set) Token: 0x06002397 RID: 9111 RVA: 0x0001461D File Offset: 0x0001281D
			public unsafe RTHandle rtMSAA
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.SwapBuffer.NativeFieldInfoPtr_rtMSAA);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.SwapBuffer.NativeFieldInfoPtr_rtMSAA), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CDD RID: 3293
			// (get) Token: 0x06002398 RID: 9112 RVA: 0x00085F94 File Offset: 0x00084194
			// (set) Token: 0x06002399 RID: 9113 RVA: 0x0001463C File Offset: 0x0001283C
			public unsafe RTHandle rtResolve
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.SwapBuffer.NativeFieldInfoPtr_rtResolve);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.SwapBuffer.NativeFieldInfoPtr_rtResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CDE RID: 3294
			// (get) Token: 0x0600239A RID: 9114 RVA: 0x00085FC4 File Offset: 0x000841C4
			// (set) Token: 0x0600239B RID: 9115 RVA: 0x0001465B File Offset: 0x0001285B
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.SwapBuffer.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.SwapBuffer.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000CDF RID: 3295
			// (get) Token: 0x0600239C RID: 9116 RVA: 0x00085FEC File Offset: 0x000841EC
			// (set) Token: 0x0600239D RID: 9117 RVA: 0x0001467A File Offset: 0x0001287A
			public unsafe int msaa
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.SwapBuffer.NativeFieldInfoPtr_msaa);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderTargetBufferSystem.SwapBuffer.NativeFieldInfoPtr_msaa)) = value;
				}
			}

			// Token: 0x040018D3 RID: 6355
			private static readonly IntPtr NativeFieldInfoPtr_rtMSAA;

			// Token: 0x040018D4 RID: 6356
			private static readonly IntPtr NativeFieldInfoPtr_rtResolve;

			// Token: 0x040018D5 RID: 6357
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040018D6 RID: 6358
			private static readonly IntPtr NativeFieldInfoPtr_msaa;
		}
	}
}
