using System;
using dwd.core.input;
using dwd.core.input.context;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace boardgames.match.behaviours
{
	// Token: 0x02000284 RID: 644
	public class MinimizablePrompt : MonoBehaviour
	{
		// Token: 0x06001E1D RID: 7709 RVA: 0x00081F20 File Offset: 0x00080120
		// Note: this type is marked as 'beforefieldinit'.
		static MinimizablePrompt()
		{
			Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.behaviours", "MinimizablePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr);
			MinimizablePrompt.NativeFieldInfoPtr_minimizeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, "minimizeButton");
			MinimizablePrompt.NativeFieldInfoPtr_minimizeAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, "minimizeAnimator");
			MinimizablePrompt.NativeFieldInfoPtr_inputContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, "inputContext");
			MinimizablePrompt.NativeFieldInfoPtr_showParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, "showParam");
			MinimizablePrompt.NativeFieldInfoPtr_hideParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, "hideParam");
			MinimizablePrompt.NativeFieldInfoPtr_playmat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, "playmat");
			MinimizablePrompt.NativeFieldInfoPtr_collapser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, "collapser");
			MinimizablePrompt.NativeFieldInfoPtr__Minimized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, "<Minimized>k__BackingField");
			MinimizablePrompt.NativeMethodInfoPtr_get_Minimized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, 100668235);
			MinimizablePrompt.NativeMethodInfoPtr_set_Minimized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, 100668236);
			MinimizablePrompt.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, 100668237);
			MinimizablePrompt.NativeMethodInfoPtr_ForceToggleMinimize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, 100668238);
			MinimizablePrompt.NativeMethodInfoPtr_Event_ToggleMinimize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, 100668239);
			MinimizablePrompt.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, 100668240);
			MinimizablePrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, 100668241);
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x0008207C File Offset: 0x0008027C
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x000820B8 File Offset: 0x000802B8
		public unsafe bool Minimized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizablePrompt.NativeMethodInfoPtr_get_Minimized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizablePrompt.NativeMethodInfoPtr_set_Minimized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x000820F8 File Offset: 0x000802F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538436, XrefRangeEnd = 538441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizablePrompt.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00082138 File Offset: 0x00080338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538441, XrefRangeEnd = 538451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceToggleMinimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizablePrompt.NativeMethodInfoPtr_ForceToggleMinimize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0008216C File Offset: 0x0008036C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 538479, RefRangeEnd = 538480, XrefRangeStart = 538451, XrefRangeEnd = 538479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleMinimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizablePrompt.NativeMethodInfoPtr_Event_ToggleMinimize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x000821A0 File Offset: 0x000803A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538480, XrefRangeEnd = 538488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizablePrompt.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x000821D4 File Offset: 0x000803D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538488, XrefRangeEnd = 538497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinimizablePrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizablePrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x0000FE43 File Offset: 0x0000E043
		public MinimizablePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x00082210 File Offset: 0x00080410
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x0000FE4C File Offset: 0x0000E04C
		public unsafe GameObject minimizeButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_minimizeButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_minimizeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x00082240 File Offset: 0x00080440
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x0000FE6B File Offset: 0x0000E06B
		public unsafe Animator minimizeAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_minimizeAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_minimizeAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00082270 File Offset: 0x00080470
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x0000FE8A File Offset: 0x0000E08A
		public unsafe CreateInputContext inputContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_inputContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateInputContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_inputContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x000822A0 File Offset: 0x000804A0
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x0000FEA9 File Offset: 0x0000E0A9
		public unsafe string showParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_showParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_showParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x000822C8 File Offset: 0x000804C8
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		public unsafe string hideParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_hideParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_hideParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x000822F0 File Offset: 0x000804F0
		// (set) Token: 0x06001E31 RID: 7729 RVA: 0x0000FEE7 File Offset: 0x0000E0E7
		public unsafe EntityComponent playmat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_playmat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_playmat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x00082320 File Offset: 0x00080520
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x0000FF06 File Offset: 0x0000E106
		public unsafe MinimizeAndDisableInputOnButtonPress collapser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_collapser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinimizeAndDisableInputOnButtonPress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr_collapser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x00082350 File Offset: 0x00080550
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x0000FF25 File Offset: 0x0000E125
		public unsafe bool _Minimized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr__Minimized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt.NativeFieldInfoPtr__Minimized_k__BackingField)) = value;
			}
		}

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeFieldInfoPtr_minimizeButton;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeFieldInfoPtr_minimizeAnimator;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeFieldInfoPtr_inputContext;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeFieldInfoPtr_showParam;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeFieldInfoPtr_hideParam;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeFieldInfoPtr_playmat;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeFieldInfoPtr_collapser;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeFieldInfoPtr__Minimized_k__BackingField;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeMethodInfoPtr_get_Minimized_Public_get_Boolean_0;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeMethodInfoPtr_set_Minimized_Private_set_Void_Boolean_0;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeMethodInfoPtr_ForceToggleMinimize_Public_Void_0;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleMinimize_Public_Void_0;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000475 RID: 1141
		[ObfuscatedName("boardgames.match.behaviours.MinimizablePrompt+<Start>d__11")]
		public sealed class _Start_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x060035F7 RID: 13815 RVA: 0x000C9A8C File Offset: 0x000C7C8C
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__11()
			{
				Il2CppClassPointerStore<MinimizablePrompt._Start_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MinimizablePrompt>.NativeClassPtr, "<Start>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinimizablePrompt._Start_d__11>.NativeClassPtr);
				MinimizablePrompt._Start_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimizablePrompt._Start_d__11>.NativeClassPtr, "<>1__state");
				MinimizablePrompt._Start_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimizablePrompt._Start_d__11>.NativeClassPtr, "<>2__current");
				MinimizablePrompt._Start_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimizablePrompt._Start_d__11>.NativeClassPtr, "<>4__this");
				MinimizablePrompt._Start_d__11.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinimizablePrompt._Start_d__11>.NativeClassPtr, "<entitiesProvider>5__2");
				MinimizablePrompt._Start_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizablePrompt._Start_d__11>.NativeClassPtr, 100668242);
				MinimizablePrompt._Start_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizablePrompt._Start_d__11>.NativeClassPtr, 100668243);
				MinimizablePrompt._Start_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizablePrompt._Start_d__11>.NativeClassPtr, 100668244);
				MinimizablePrompt._Start_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizablePrompt._Start_d__11>.NativeClassPtr, 100668245);
				MinimizablePrompt._Start_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizablePrompt._Start_d__11>.NativeClassPtr, 100668246);
				MinimizablePrompt._Start_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinimizablePrompt._Start_d__11>.NativeClassPtr, 100668247);
			}

			// Token: 0x060035F8 RID: 13816 RVA: 0x000C9B80 File Offset: 0x000C7D80
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinimizablePrompt._Start_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizablePrompt._Start_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060035F9 RID: 13817 RVA: 0x000C9BC8 File Offset: 0x000C7DC8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizablePrompt._Start_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035FA RID: 13818 RVA: 0x000C9BFC File Offset: 0x000C7DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538409, XrefRangeEnd = 538431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizablePrompt._Start_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000FD9 RID: 4057
			// (get) Token: 0x060035FB RID: 13819 RVA: 0x000C9C38 File Offset: 0x000C7E38
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizablePrompt._Start_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060035FC RID: 13820 RVA: 0x000C9C78 File Offset: 0x000C7E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538431, XrefRangeEnd = 538436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizablePrompt._Start_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FDA RID: 4058
			// (get) Token: 0x060035FD RID: 13821 RVA: 0x000C9CAC File Offset: 0x000C7EAC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinimizablePrompt._Start_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060035FE RID: 13822 RVA: 0x0001BD15 File Offset: 0x00019F15
			public _Start_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FD5 RID: 4053
			// (get) Token: 0x060035FF RID: 13823 RVA: 0x000C9CEC File Offset: 0x000C7EEC
			// (set) Token: 0x06003600 RID: 13824 RVA: 0x0001BD1E File Offset: 0x00019F1E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt._Start_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt._Start_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FD6 RID: 4054
			// (get) Token: 0x06003601 RID: 13825 RVA: 0x000C9D14 File Offset: 0x000C7F14
			// (set) Token: 0x06003602 RID: 13826 RVA: 0x0001BD39 File Offset: 0x00019F39
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt._Start_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt._Start_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD7 RID: 4055
			// (get) Token: 0x06003603 RID: 13827 RVA: 0x000C9D44 File Offset: 0x000C7F44
			// (set) Token: 0x06003604 RID: 13828 RVA: 0x0001BD58 File Offset: 0x00019F58
			public unsafe MinimizablePrompt __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt._Start_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinimizablePrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt._Start_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD8 RID: 4056
			// (get) Token: 0x06003605 RID: 13829 RVA: 0x000C9D74 File Offset: 0x000C7F74
			// (set) Token: 0x06003606 RID: 13830 RVA: 0x0001BD77 File Offset: 0x00019F77
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt._Start_d__11.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinimizablePrompt._Start_d__11.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002137 RID: 8503
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002138 RID: 8504
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002139 RID: 8505
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400213A RID: 8506
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x0400213B RID: 8507
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400213C RID: 8508
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400213D RID: 8509
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400213E RID: 8510
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400213F RID: 8511
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002140 RID: 8512
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
