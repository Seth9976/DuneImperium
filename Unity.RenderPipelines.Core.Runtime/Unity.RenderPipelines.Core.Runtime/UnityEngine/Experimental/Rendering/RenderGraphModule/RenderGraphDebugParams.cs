using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000012 RID: 18
	public class RenderGraphDebugParams : Object
	{
		// Token: 0x06000155 RID: 341 RVA: 0x0001218C File Offset: 0x0001038C
		// Note: this type is marked as 'beforefieldinit'.
		static RenderGraphDebugParams()
		{
			Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "RenderGraphDebugParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr);
			RenderGraphDebugParams.NativeFieldInfoPtr_m_DebugItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "m_DebugItems");
			RenderGraphDebugParams.NativeFieldInfoPtr_m_DebugPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "m_DebugPanel");
			RenderGraphDebugParams.NativeFieldInfoPtr_clearRenderTargetsAtCreation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "clearRenderTargetsAtCreation");
			RenderGraphDebugParams.NativeFieldInfoPtr_clearRenderTargetsAtRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "clearRenderTargetsAtRelease");
			RenderGraphDebugParams.NativeFieldInfoPtr_disablePassCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "disablePassCulling");
			RenderGraphDebugParams.NativeFieldInfoPtr_immediateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "immediateMode");
			RenderGraphDebugParams.NativeFieldInfoPtr_enableLogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "enableLogging");
			RenderGraphDebugParams.NativeFieldInfoPtr_logFrameInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "logFrameInformation");
			RenderGraphDebugParams.NativeFieldInfoPtr_logResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "logResources");
			RenderGraphDebugParams.NativeMethodInfoPtr_RegisterDebug_Public_Void_String_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100663419);
			RenderGraphDebugParams.NativeMethodInfoPtr_UnRegisterDebug_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100663420);
			RenderGraphDebugParams.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100663421);
			RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100663422);
			RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100663423);
			RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100663424);
			RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_3_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100663425);
			RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_4_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100663426);
			RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_5_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100663427);
			RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_6_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100663428);
			RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_7_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100663429);
			RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100663430);
			RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_9_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100663431);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00012374 File Offset: 0x00010574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 954748, RefRangeEnd = 954749, XrefRangeStart = 954599, XrefRangeEnd = 954748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDebug(string name, DebugUI.Panel debugPanel = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(debugPanel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugParams.NativeMethodInfoPtr_RegisterDebug_Public_Void_String_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000123C8 File Offset: 0x000105C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954749, XrefRangeEnd = 954755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnRegisterDebug(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugParams.NativeMethodInfoPtr_UnRegisterDebug_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0001240C File Offset: 0x0001060C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderGraphDebugParams()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugParams.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00012448 File Offset: 0x00010648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RegisterDebug_b__10_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00012484 File Offset: 0x00010684
		[CallerCount(0)]
		public unsafe void _RegisterDebug_b__10_1(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000124C4 File Offset: 0x000106C4
		[CallerCount(0)]
		public unsafe bool _RegisterDebug_b__10_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00012500 File Offset: 0x00010700
		[CallerCount(0)]
		public unsafe void _RegisterDebug_b__10_3(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_3_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00012540 File Offset: 0x00010740
		[CallerCount(0)]
		public unsafe bool _RegisterDebug_b__10_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_4_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0001257C File Offset: 0x0001077C
		[CallerCount(0)]
		public unsafe void _RegisterDebug_b__10_5(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_5_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000125BC File Offset: 0x000107BC
		[CallerCount(0)]
		public unsafe bool _RegisterDebug_b__10_6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_6_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000125F8 File Offset: 0x000107F8
		[CallerCount(0)]
		public unsafe void _RegisterDebug_b__10_7(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_7_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00012638 File Offset: 0x00010838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954755, XrefRangeEnd = 954761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RegisterDebug_b__10_8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0001266C File Offset: 0x0001086C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954761, XrefRangeEnd = 954767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RegisterDebug_b__10_9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderGraphDebugParams.NativeMethodInfoPtr__RegisterDebug_b__10_9_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000029B1 File Offset: 0x00000BB1
		public RenderGraphDebugParams(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000126A0 File Offset: 0x000108A0
		// (set) Token: 0x06000165 RID: 357 RVA: 0x000029BA File Offset: 0x00000BBA
		public unsafe Il2CppReferenceArray<DebugUI.Widget> m_DebugItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_m_DebugItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DebugUI.Widget>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_m_DebugItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000126D0 File Offset: 0x000108D0
		// (set) Token: 0x06000167 RID: 359 RVA: 0x000029D9 File Offset: 0x00000BD9
		public unsafe DebugUI.Panel m_DebugPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_m_DebugPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.Panel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_m_DebugPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00012700 File Offset: 0x00010900
		// (set) Token: 0x06000169 RID: 361 RVA: 0x000029F8 File Offset: 0x00000BF8
		public unsafe bool clearRenderTargetsAtCreation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_clearRenderTargetsAtCreation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_clearRenderTargetsAtCreation)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00012728 File Offset: 0x00010928
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002A13 File Offset: 0x00000C13
		public unsafe bool clearRenderTargetsAtRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_clearRenderTargetsAtRelease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_clearRenderTargetsAtRelease)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00012750 File Offset: 0x00010950
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002A2E File Offset: 0x00000C2E
		public unsafe bool disablePassCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_disablePassCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_disablePassCulling)) = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00012778 File Offset: 0x00010978
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002A49 File Offset: 0x00000C49
		public unsafe bool immediateMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_immediateMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_immediateMode)) = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000127A0 File Offset: 0x000109A0
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00002A64 File Offset: 0x00000C64
		public unsafe bool enableLogging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_enableLogging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_enableLogging)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000127C8 File Offset: 0x000109C8
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00002A7F File Offset: 0x00000C7F
		public unsafe bool logFrameInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_logFrameInformation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_logFrameInformation)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000127F0 File Offset: 0x000109F0
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00002A9A File Offset: 0x00000C9A
		public unsafe bool logResources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_logResources);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderGraphDebugParams.NativeFieldInfoPtr_logResources)) = value;
			}
		}

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugItems;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugPanel;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_clearRenderTargetsAtCreation;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_clearRenderTargetsAtRelease;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_disablePassCulling;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_immediateMode;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_enableLogging;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_logFrameInformation;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_logResources;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDebug_Public_Void_String_Panel_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterDebug_Public_Void_String_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__10_0_Private_Boolean_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__10_1_Private_Void_Boolean_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__10_2_Private_Boolean_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__10_3_Private_Void_Boolean_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__10_4_Private_Boolean_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__10_5_Private_Void_Boolean_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__10_6_Private_Boolean_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__10_7_Private_Void_Boolean_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__10_8_Private_Void_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr__RegisterDebug_b__10_9_Private_Void_0;

		// Token: 0x02000145 RID: 325
		public static class Strings : Object
		{
			// Token: 0x06001522 RID: 5410 RVA: 0x0005CEA8 File Offset: 0x0005B0A8
			// Note: this type is marked as 'beforefieldinit'.
			static Strings()
			{
				Il2CppClassPointerStore<RenderGraphDebugParams.Strings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "Strings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphDebugParams.Strings>.NativeClassPtr);
				RenderGraphDebugParams.Strings.NativeFieldInfoPtr_ClearRenderTargetsAtCreation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams.Strings>.NativeClassPtr, "ClearRenderTargetsAtCreation");
				RenderGraphDebugParams.Strings.NativeFieldInfoPtr_DisablePassCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams.Strings>.NativeClassPtr, "DisablePassCulling");
				RenderGraphDebugParams.Strings.NativeFieldInfoPtr_ImmediateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams.Strings>.NativeClassPtr, "ImmediateMode");
				RenderGraphDebugParams.Strings.NativeFieldInfoPtr_EnableLogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams.Strings>.NativeClassPtr, "EnableLogging");
				RenderGraphDebugParams.Strings.NativeFieldInfoPtr_LogFrameInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams.Strings>.NativeClassPtr, "LogFrameInformation");
				RenderGraphDebugParams.Strings.NativeFieldInfoPtr_LogResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams.Strings>.NativeClassPtr, "LogResources");
			}

			// Token: 0x06001523 RID: 5411 RVA: 0x0000AA7E File Offset: 0x00008C7E
			public Strings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005ED RID: 1517
			// (get) Token: 0x06001524 RID: 5412 RVA: 0x0005CF4C File Offset: 0x0005B14C
			// (set) Token: 0x06001525 RID: 5413 RVA: 0x0000AA87 File Offset: 0x00008C87
			public unsafe static DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(RenderGraphDebugParams.Strings.NativeFieldInfoPtr_ClearRenderTargetsAtCreation, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderGraphDebugParams.Strings.NativeFieldInfoPtr_ClearRenderTargetsAtCreation, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x170005EE RID: 1518
			// (get) Token: 0x06001526 RID: 5414 RVA: 0x0005CF88 File Offset: 0x0005B188
			// (set) Token: 0x06001527 RID: 5415 RVA: 0x0000AA9E File Offset: 0x00008C9E
			public unsafe static DebugUI.Widget.NameAndTooltip DisablePassCulling
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(RenderGraphDebugParams.Strings.NativeFieldInfoPtr_DisablePassCulling, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderGraphDebugParams.Strings.NativeFieldInfoPtr_DisablePassCulling, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x170005EF RID: 1519
			// (get) Token: 0x06001528 RID: 5416 RVA: 0x0005CFC4 File Offset: 0x0005B1C4
			// (set) Token: 0x06001529 RID: 5417 RVA: 0x0000AAB5 File Offset: 0x00008CB5
			public unsafe static DebugUI.Widget.NameAndTooltip ImmediateMode
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(RenderGraphDebugParams.Strings.NativeFieldInfoPtr_ImmediateMode, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderGraphDebugParams.Strings.NativeFieldInfoPtr_ImmediateMode, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x170005F0 RID: 1520
			// (get) Token: 0x0600152A RID: 5418 RVA: 0x0005D000 File Offset: 0x0005B200
			// (set) Token: 0x0600152B RID: 5419 RVA: 0x0000AACC File Offset: 0x00008CCC
			public unsafe static DebugUI.Widget.NameAndTooltip EnableLogging
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(RenderGraphDebugParams.Strings.NativeFieldInfoPtr_EnableLogging, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderGraphDebugParams.Strings.NativeFieldInfoPtr_EnableLogging, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x170005F1 RID: 1521
			// (get) Token: 0x0600152C RID: 5420 RVA: 0x0005D03C File Offset: 0x0005B23C
			// (set) Token: 0x0600152D RID: 5421 RVA: 0x0000AAE3 File Offset: 0x00008CE3
			public unsafe static DebugUI.Widget.NameAndTooltip LogFrameInformation
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(RenderGraphDebugParams.Strings.NativeFieldInfoPtr_LogFrameInformation, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderGraphDebugParams.Strings.NativeFieldInfoPtr_LogFrameInformation, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x170005F2 RID: 1522
			// (get) Token: 0x0600152E RID: 5422 RVA: 0x0005D078 File Offset: 0x0005B278
			// (set) Token: 0x0600152F RID: 5423 RVA: 0x0000AAFA File Offset: 0x00008CFA
			public unsafe static DebugUI.Widget.NameAndTooltip LogResources
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(RenderGraphDebugParams.Strings.NativeFieldInfoPtr_LogResources, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RenderGraphDebugParams.Strings.NativeFieldInfoPtr_LogResources, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x04000F90 RID: 3984
			private static readonly IntPtr NativeFieldInfoPtr_ClearRenderTargetsAtCreation;

			// Token: 0x04000F91 RID: 3985
			private static readonly IntPtr NativeFieldInfoPtr_DisablePassCulling;

			// Token: 0x04000F92 RID: 3986
			private static readonly IntPtr NativeFieldInfoPtr_ImmediateMode;

			// Token: 0x04000F93 RID: 3987
			private static readonly IntPtr NativeFieldInfoPtr_EnableLogging;

			// Token: 0x04000F94 RID: 3988
			private static readonly IntPtr NativeFieldInfoPtr_LogFrameInformation;

			// Token: 0x04000F95 RID: 3989
			private static readonly IntPtr NativeFieldInfoPtr_LogResources;
		}
	}
}
