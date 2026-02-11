using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200024E RID: 590
	[StructLayout(2)]
	public struct StencilState
	{
		// Token: 0x060027C9 RID: 10185 RVA: 0x000A7A00 File Offset: 0x000A5C00
		// Note: this type is marked as 'beforefieldinit'.
		static StencilState()
		{
			Il2CppClassPointerStore<StencilState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "StencilState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilState>.NativeClassPtr);
			StencilState.NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_Enabled");
			StencilState.NativeFieldInfoPtr_m_ReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_ReadMask");
			StencilState.NativeFieldInfoPtr_m_WriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_WriteMask");
			StencilState.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_Padding");
			StencilState.NativeFieldInfoPtr_m_CompareFunctionFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_CompareFunctionFront");
			StencilState.NativeFieldInfoPtr_m_PassOperationFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_PassOperationFront");
			StencilState.NativeFieldInfoPtr_m_FailOperationFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_FailOperationFront");
			StencilState.NativeFieldInfoPtr_m_ZFailOperationFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_ZFailOperationFront");
			StencilState.NativeFieldInfoPtr_m_CompareFunctionBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_CompareFunctionBack");
			StencilState.NativeFieldInfoPtr_m_PassOperationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_PassOperationBack");
			StencilState.NativeFieldInfoPtr_m_FailOperationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_FailOperationBack");
			StencilState.NativeFieldInfoPtr_m_ZFailOperationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_ZFailOperationBack");
			StencilState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668399);
			StencilState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668400);
			StencilState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_CompareFunction_StencilOp_StencilOp_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668401);
			StencilState.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668402);
			StencilState.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668403);
			StencilState.NativeMethodInfoPtr_get_readMask_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668404);
			StencilState.NativeMethodInfoPtr_set_readMask_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668405);
			StencilState.NativeMethodInfoPtr_get_writeMask_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668406);
			StencilState.NativeMethodInfoPtr_set_writeMask_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668407);
			StencilState.NativeMethodInfoPtr_SetCompareFunction_Public_Void_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668408);
			StencilState.NativeMethodInfoPtr_SetPassOperation_Public_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668409);
			StencilState.NativeMethodInfoPtr_SetFailOperation_Public_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668410);
			StencilState.NativeMethodInfoPtr_SetZFailOperation_Public_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668411);
			StencilState.NativeMethodInfoPtr_get_compareFunctionFront_Public_get_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668412);
			StencilState.NativeMethodInfoPtr_set_compareFunctionFront_Public_set_Void_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668413);
			StencilState.NativeMethodInfoPtr_get_passOperationFront_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668414);
			StencilState.NativeMethodInfoPtr_set_passOperationFront_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668415);
			StencilState.NativeMethodInfoPtr_get_failOperationFront_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668416);
			StencilState.NativeMethodInfoPtr_set_failOperationFront_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668417);
			StencilState.NativeMethodInfoPtr_get_zFailOperationFront_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668418);
			StencilState.NativeMethodInfoPtr_set_zFailOperationFront_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668419);
			StencilState.NativeMethodInfoPtr_get_compareFunctionBack_Public_get_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668420);
			StencilState.NativeMethodInfoPtr_set_compareFunctionBack_Public_set_Void_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668421);
			StencilState.NativeMethodInfoPtr_get_passOperationBack_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668422);
			StencilState.NativeMethodInfoPtr_set_passOperationBack_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668423);
			StencilState.NativeMethodInfoPtr_get_failOperationBack_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668424);
			StencilState.NativeMethodInfoPtr_set_failOperationBack_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668425);
			StencilState.NativeMethodInfoPtr_get_zFailOperationBack_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668426);
			StencilState.NativeMethodInfoPtr_set_zFailOperationBack_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668427);
			StencilState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668428);
			StencilState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668429);
			StencilState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668430);
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x000A7DA0 File Offset: 0x000A5FA0
		public unsafe static StencilState defaultValue
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 685073, RefRangeEnd = 685076, XrefRangeStart = 685069, XrefRangeEnd = 685073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_StencilState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x000A7DD0 File Offset: 0x000A5FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685076, XrefRangeEnd = 685077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StencilState(bool enabled = true, byte readMask = 255, byte writeMask = 255, CompareFunction compareFunction = CompareFunction.Always, StencilOp passOperation = StencilOp.Keep, StencilOp failOperation = StencilOp.Keep, StencilOp zFailOperation = StencilOp.Keep)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readMask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passOperation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failOperation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFailOperation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x000A7E58 File Offset: 0x000A6058
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 685081, RefRangeEnd = 685085, XrefRangeStart = 685077, XrefRangeEnd = 685081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StencilState(bool enabled, byte readMask, byte writeMask, CompareFunction compareFunctionFront, StencilOp passOperationFront, StencilOp failOperationFront, StencilOp zFailOperationFront, CompareFunction compareFunctionBack, StencilOp passOperationBack, StencilOp failOperationBack, StencilOp zFailOperationBack)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readMask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunctionFront;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passOperationFront;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failOperationFront;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFailOperationFront;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunctionBack;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passOperationBack;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failOperationBack;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFailOperationBack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_CompareFunction_StencilOp_StencilOp_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060027CD RID: 10189 RVA: 0x000A7F1C File Offset: 0x000A611C
		// (set) Token: 0x060027CE RID: 10190 RVA: 0x000A7F4C File Offset: 0x000A614C
		public unsafe bool enabled
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 685089, RefRangeEnd = 685092, XrefRangeStart = 685085, XrefRangeEnd = 685089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 685096, RefRangeEnd = 685100, XrefRangeStart = 685092, XrefRangeEnd = 685096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060027CF RID: 10191 RVA: 0x000A7F80 File Offset: 0x000A6180
		// (set) Token: 0x060027D0 RID: 10192 RVA: 0x000A7FB0 File Offset: 0x000A61B0
		public unsafe byte readMask
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 685100, RefRangeEnd = 685102, XrefRangeStart = 685100, XrefRangeEnd = 685100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_readMask_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685102, RefRangeEnd = 685103, XrefRangeStart = 685102, XrefRangeEnd = 685102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_readMask_Public_set_Void_Byte_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060027D1 RID: 10193 RVA: 0x000A7FE4 File Offset: 0x000A61E4
		// (set) Token: 0x060027D2 RID: 10194 RVA: 0x000A8014 File Offset: 0x000A6214
		public unsafe byte writeMask
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 685103, RefRangeEnd = 685105, XrefRangeStart = 685103, XrefRangeEnd = 685103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_writeMask_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685105, RefRangeEnd = 685106, XrefRangeStart = 685105, XrefRangeEnd = 685105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_writeMask_Public_set_Void_Byte_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x000A8048 File Offset: 0x000A6248
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 685106, RefRangeEnd = 685109, XrefRangeStart = 685106, XrefRangeEnd = 685106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCompareFunction(CompareFunction value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_SetCompareFunction_Public_Void_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x000A807C File Offset: 0x000A627C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 685109, RefRangeEnd = 685112, XrefRangeStart = 685109, XrefRangeEnd = 685109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPassOperation(StencilOp value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_SetPassOperation_Public_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x000A80B0 File Offset: 0x000A62B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 685112, RefRangeEnd = 685115, XrefRangeStart = 685112, XrefRangeEnd = 685112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFailOperation(StencilOp value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_SetFailOperation_Public_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x000A80E4 File Offset: 0x000A62E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 685115, RefRangeEnd = 685118, XrefRangeStart = 685115, XrefRangeEnd = 685115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZFailOperation(StencilOp value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_SetZFailOperation_Public_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060027D7 RID: 10199 RVA: 0x000A8118 File Offset: 0x000A6318
		// (set) Token: 0x060027D8 RID: 10200 RVA: 0x000A8148 File Offset: 0x000A6348
		public unsafe CompareFunction compareFunctionFront
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 685118, RefRangeEnd = 685122, XrefRangeStart = 685118, XrefRangeEnd = 685118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_compareFunctionFront_Public_get_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685122, RefRangeEnd = 685123, XrefRangeStart = 685122, XrefRangeEnd = 685122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_compareFunctionFront_Public_set_Void_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x000A817C File Offset: 0x000A637C
		// (set) Token: 0x060027DA RID: 10202 RVA: 0x000A81AC File Offset: 0x000A63AC
		public unsafe StencilOp passOperationFront
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 685123, RefRangeEnd = 685125, XrefRangeStart = 685123, XrefRangeEnd = 685123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_passOperationFront_Public_get_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685125, RefRangeEnd = 685126, XrefRangeStart = 685125, XrefRangeEnd = 685125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_passOperationFront_Public_set_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x000A81E0 File Offset: 0x000A63E0
		// (set) Token: 0x060027DC RID: 10204 RVA: 0x000A8210 File Offset: 0x000A6410
		public unsafe StencilOp failOperationFront
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 685126, RefRangeEnd = 685128, XrefRangeStart = 685126, XrefRangeEnd = 685126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_failOperationFront_Public_get_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685128, RefRangeEnd = 685129, XrefRangeStart = 685128, XrefRangeEnd = 685128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_failOperationFront_Public_set_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x000A8244 File Offset: 0x000A6444
		// (set) Token: 0x060027DE RID: 10206 RVA: 0x000A8274 File Offset: 0x000A6474
		public unsafe StencilOp zFailOperationFront
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 685129, RefRangeEnd = 685131, XrefRangeStart = 685129, XrefRangeEnd = 685129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_zFailOperationFront_Public_get_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685131, RefRangeEnd = 685132, XrefRangeStart = 685131, XrefRangeEnd = 685131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_zFailOperationFront_Public_set_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x000A82A8 File Offset: 0x000A64A8
		// (set) Token: 0x060027E0 RID: 10208 RVA: 0x000A82D8 File Offset: 0x000A64D8
		public unsafe CompareFunction compareFunctionBack
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 685132, RefRangeEnd = 685136, XrefRangeStart = 685132, XrefRangeEnd = 685132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_compareFunctionBack_Public_get_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685136, RefRangeEnd = 685137, XrefRangeStart = 685136, XrefRangeEnd = 685136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_compareFunctionBack_Public_set_Void_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x000A830C File Offset: 0x000A650C
		// (set) Token: 0x060027E2 RID: 10210 RVA: 0x000A833C File Offset: 0x000A653C
		public unsafe StencilOp passOperationBack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 685137, RefRangeEnd = 685139, XrefRangeStart = 685137, XrefRangeEnd = 685137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_passOperationBack_Public_get_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685139, RefRangeEnd = 685140, XrefRangeStart = 685139, XrefRangeEnd = 685139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_passOperationBack_Public_set_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x000A8370 File Offset: 0x000A6570
		// (set) Token: 0x060027E4 RID: 10212 RVA: 0x000A83A0 File Offset: 0x000A65A0
		public unsafe StencilOp failOperationBack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 685140, RefRangeEnd = 685142, XrefRangeStart = 685140, XrefRangeEnd = 685140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_failOperationBack_Public_get_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685142, RefRangeEnd = 685143, XrefRangeStart = 685142, XrefRangeEnd = 685142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_failOperationBack_Public_set_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x000A83D4 File Offset: 0x000A65D4
		// (set) Token: 0x060027E6 RID: 10214 RVA: 0x000A8404 File Offset: 0x000A6604
		public unsafe StencilOp zFailOperationBack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 685143, RefRangeEnd = 685145, XrefRangeStart = 685143, XrefRangeEnd = 685143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_zFailOperationBack_Public_get_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 685145, RefRangeEnd = 685146, XrefRangeStart = 685145, XrefRangeEnd = 685145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_zFailOperationBack_Public_set_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x000A8438 File Offset: 0x000A6638
		[CallerCount(0)]
		public unsafe bool Equals(StencilState other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StencilState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x000A8478 File Offset: 0x000A6678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685146, XrefRangeEnd = 685150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x000A84BC File Offset: 0x000A66BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 685161, RefRangeEnd = 685162, XrefRangeStart = 685150, XrefRangeEnd = 685161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x0000F658 File Offset: 0x0000D858
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StencilState>.NativeClassPtr, ref this));
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x000A84EC File Offset: 0x000A66EC
		public static bool operator ==(StencilState left, StencilState right)
		{
			return left.Equals(right);
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x000A8508 File Offset: 0x000A6708
		public static bool operator !=(StencilState left, StencilState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0400238B RID: 9099
		private static readonly IntPtr NativeFieldInfoPtr_m_Enabled;

		// Token: 0x0400238C RID: 9100
		private static readonly IntPtr NativeFieldInfoPtr_m_ReadMask;

		// Token: 0x0400238D RID: 9101
		private static readonly IntPtr NativeFieldInfoPtr_m_WriteMask;

		// Token: 0x0400238E RID: 9102
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x0400238F RID: 9103
		private static readonly IntPtr NativeFieldInfoPtr_m_CompareFunctionFront;

		// Token: 0x04002390 RID: 9104
		private static readonly IntPtr NativeFieldInfoPtr_m_PassOperationFront;

		// Token: 0x04002391 RID: 9105
		private static readonly IntPtr NativeFieldInfoPtr_m_FailOperationFront;

		// Token: 0x04002392 RID: 9106
		private static readonly IntPtr NativeFieldInfoPtr_m_ZFailOperationFront;

		// Token: 0x04002393 RID: 9107
		private static readonly IntPtr NativeFieldInfoPtr_m_CompareFunctionBack;

		// Token: 0x04002394 RID: 9108
		private static readonly IntPtr NativeFieldInfoPtr_m_PassOperationBack;

		// Token: 0x04002395 RID: 9109
		private static readonly IntPtr NativeFieldInfoPtr_m_FailOperationBack;

		// Token: 0x04002396 RID: 9110
		private static readonly IntPtr NativeFieldInfoPtr_m_ZFailOperationBack;

		// Token: 0x04002397 RID: 9111
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultValue_Public_Static_get_StencilState_0;

		// Token: 0x04002398 RID: 9112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_0;

		// Token: 0x04002399 RID: 9113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_CompareFunction_StencilOp_StencilOp_StencilOp_0;

		// Token: 0x0400239A RID: 9114
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x0400239B RID: 9115
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x0400239C RID: 9116
		private static readonly IntPtr NativeMethodInfoPtr_get_readMask_Public_get_Byte_0;

		// Token: 0x0400239D RID: 9117
		private static readonly IntPtr NativeMethodInfoPtr_set_readMask_Public_set_Void_Byte_0;

		// Token: 0x0400239E RID: 9118
		private static readonly IntPtr NativeMethodInfoPtr_get_writeMask_Public_get_Byte_0;

		// Token: 0x0400239F RID: 9119
		private static readonly IntPtr NativeMethodInfoPtr_set_writeMask_Public_set_Void_Byte_0;

		// Token: 0x040023A0 RID: 9120
		private static readonly IntPtr NativeMethodInfoPtr_SetCompareFunction_Public_Void_CompareFunction_0;

		// Token: 0x040023A1 RID: 9121
		private static readonly IntPtr NativeMethodInfoPtr_SetPassOperation_Public_Void_StencilOp_0;

		// Token: 0x040023A2 RID: 9122
		private static readonly IntPtr NativeMethodInfoPtr_SetFailOperation_Public_Void_StencilOp_0;

		// Token: 0x040023A3 RID: 9123
		private static readonly IntPtr NativeMethodInfoPtr_SetZFailOperation_Public_Void_StencilOp_0;

		// Token: 0x040023A4 RID: 9124
		private static readonly IntPtr NativeMethodInfoPtr_get_compareFunctionFront_Public_get_CompareFunction_0;

		// Token: 0x040023A5 RID: 9125
		private static readonly IntPtr NativeMethodInfoPtr_set_compareFunctionFront_Public_set_Void_CompareFunction_0;

		// Token: 0x040023A6 RID: 9126
		private static readonly IntPtr NativeMethodInfoPtr_get_passOperationFront_Public_get_StencilOp_0;

		// Token: 0x040023A7 RID: 9127
		private static readonly IntPtr NativeMethodInfoPtr_set_passOperationFront_Public_set_Void_StencilOp_0;

		// Token: 0x040023A8 RID: 9128
		private static readonly IntPtr NativeMethodInfoPtr_get_failOperationFront_Public_get_StencilOp_0;

		// Token: 0x040023A9 RID: 9129
		private static readonly IntPtr NativeMethodInfoPtr_set_failOperationFront_Public_set_Void_StencilOp_0;

		// Token: 0x040023AA RID: 9130
		private static readonly IntPtr NativeMethodInfoPtr_get_zFailOperationFront_Public_get_StencilOp_0;

		// Token: 0x040023AB RID: 9131
		private static readonly IntPtr NativeMethodInfoPtr_set_zFailOperationFront_Public_set_Void_StencilOp_0;

		// Token: 0x040023AC RID: 9132
		private static readonly IntPtr NativeMethodInfoPtr_get_compareFunctionBack_Public_get_CompareFunction_0;

		// Token: 0x040023AD RID: 9133
		private static readonly IntPtr NativeMethodInfoPtr_set_compareFunctionBack_Public_set_Void_CompareFunction_0;

		// Token: 0x040023AE RID: 9134
		private static readonly IntPtr NativeMethodInfoPtr_get_passOperationBack_Public_get_StencilOp_0;

		// Token: 0x040023AF RID: 9135
		private static readonly IntPtr NativeMethodInfoPtr_set_passOperationBack_Public_set_Void_StencilOp_0;

		// Token: 0x040023B0 RID: 9136
		private static readonly IntPtr NativeMethodInfoPtr_get_failOperationBack_Public_get_StencilOp_0;

		// Token: 0x040023B1 RID: 9137
		private static readonly IntPtr NativeMethodInfoPtr_set_failOperationBack_Public_set_Void_StencilOp_0;

		// Token: 0x040023B2 RID: 9138
		private static readonly IntPtr NativeMethodInfoPtr_get_zFailOperationBack_Public_get_StencilOp_0;

		// Token: 0x040023B3 RID: 9139
		private static readonly IntPtr NativeMethodInfoPtr_set_zFailOperationBack_Public_set_Void_StencilOp_0;

		// Token: 0x040023B4 RID: 9140
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StencilState_0;

		// Token: 0x040023B5 RID: 9141
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040023B6 RID: 9142
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040023B7 RID: 9143
		[FieldOffset(0)]
		public byte m_Enabled;

		// Token: 0x040023B8 RID: 9144
		[FieldOffset(1)]
		public byte m_ReadMask;

		// Token: 0x040023B9 RID: 9145
		[FieldOffset(2)]
		public byte m_WriteMask;

		// Token: 0x040023BA RID: 9146
		[FieldOffset(3)]
		public byte m_Padding;

		// Token: 0x040023BB RID: 9147
		[FieldOffset(4)]
		public byte m_CompareFunctionFront;

		// Token: 0x040023BC RID: 9148
		[FieldOffset(5)]
		public byte m_PassOperationFront;

		// Token: 0x040023BD RID: 9149
		[FieldOffset(6)]
		public byte m_FailOperationFront;

		// Token: 0x040023BE RID: 9150
		[FieldOffset(7)]
		public byte m_ZFailOperationFront;

		// Token: 0x040023BF RID: 9151
		[FieldOffset(8)]
		public byte m_CompareFunctionBack;

		// Token: 0x040023C0 RID: 9152
		[FieldOffset(9)]
		public byte m_PassOperationBack;

		// Token: 0x040023C1 RID: 9153
		[FieldOffset(10)]
		public byte m_FailOperationBack;

		// Token: 0x040023C2 RID: 9154
		[FieldOffset(11)]
		public byte m_ZFailOperationBack;
	}
}
