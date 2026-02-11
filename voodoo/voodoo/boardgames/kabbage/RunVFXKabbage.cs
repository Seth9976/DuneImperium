using System;
using dwd.core.commands;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using voodoo.kabbage;

namespace boardgames.kabbage
{
	// Token: 0x02000095 RID: 149
	public class RunVFXKabbage : Command
	{
		// Token: 0x060008C0 RID: 2240 RVA: 0x000268A8 File Offset: 0x00024AA8
		// Note: this type is marked as 'beforefieldinit'.
		static RunVFXKabbage()
		{
			Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.kabbage", "RunVFXKabbage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr);
			RunVFXKabbage.NativeFieldInfoPtr_moveContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, "moveContext");
			RunVFXKabbage.NativeFieldInfoPtr_fxData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, "fxData");
			RunVFXKabbage.NativeFieldInfoPtr_numUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, "numUnits");
			RunVFXKabbage.NativeFieldInfoPtr_myKabbages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, "myKabbages");
			RunVFXKabbage.NativeFieldInfoPtr_numUnblocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, "numUnblocked");
			RunVFXKabbage.NativeFieldInfoPtr_numCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, "numCompleted");
			RunVFXKabbage.NativeFieldInfoPtr_useFXUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, "useFXUnit");
			RunVFXKabbage.NativeFieldInfoPtr_poolManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, "poolManager");
			RunVFXKabbage.NativeFieldInfoPtr_viewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, "viewManager");
			RunVFXKabbage.NativeFieldInfoPtr__Interrupted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, "<Interrupted>k__BackingField");
			RunVFXKabbage.NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, 100664562);
			RunVFXKabbage.NativeMethodInfoPtr_get_AllComplete_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, 100664563);
			RunVFXKabbage.NativeMethodInfoPtr__ctor_Public_Void_FlavoredVFXMoveContext_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, 100664564);
			RunVFXKabbage.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, 100664565);
			RunVFXKabbage.NativeMethodInfoPtr_Complete_Public_Void_VoodooRenderAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, 100664566);
			RunVFXKabbage.NativeMethodInfoPtr_Interrupt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, 100664567);
			RunVFXKabbage.NativeMethodInfoPtr_TriggerOutro_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, 100664568);
			RunVFXKabbage.NativeMethodInfoPtr_get_Interrupted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, 100664569);
			RunVFXKabbage.NativeMethodInfoPtr_set_Interrupted_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, 100664570);
			RunVFXKabbage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, 100664571);
			RunVFXKabbage.NativeMethodInfoPtr__execute_b__14_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, 100664572);
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00026A7C File Offset: 0x00024C7C
		public unsafe bool Blocking
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116771, XrefRangeEnd = 1116772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage.NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00026AB8 File Offset: 0x00024CB8
		public unsafe bool AllComplete
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116772, XrefRangeEnd = 1116773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage.NativeMethodInfoPtr_get_AllComplete_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00026AF4 File Offset: 0x00024CF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1116791, RefRangeEnd = 1116793, XrefRangeStart = 1116773, XrefRangeEnd = 1116791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunVFXKabbage(FlavoredVFXMoveContext moveContext, EntityComponent fxData = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(moveContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fxData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage.NativeMethodInfoPtr__ctor_Public_Void_FlavoredVFXMoveContext_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00026B54 File Offset: 0x00024D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116793, XrefRangeEnd = 1116798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunVFXKabbage.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00026BA0 File Offset: 0x00024DA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1116824, RefRangeEnd = 1116827, XrefRangeStart = 1116798, XrefRangeEnd = 1116824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(VoodooRenderAnimator kabbage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(kabbage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage.NativeMethodInfoPtr_Complete_Public_Void_VoodooRenderAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00026BE4 File Offset: 0x00024DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116827, XrefRangeEnd = 1116860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage.NativeMethodInfoPtr_Interrupt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00026C18 File Offset: 0x00024E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116860, XrefRangeEnd = 1116900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TriggerOutro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage.NativeMethodInfoPtr_TriggerOutro_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00026C4C File Offset: 0x00024E4C
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00026C88 File Offset: 0x00024E88
		public unsafe bool Interrupted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage.NativeMethodInfoPtr_get_Interrupted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage.NativeMethodInfoPtr_set_Interrupted_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00026CC8 File Offset: 0x00024EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116900, XrefRangeEnd = 1116925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunVFXKabbage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00026D0C File Offset: 0x00024F0C
		[CallerCount(0)]
		public unsafe void _execute_b__14_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage.NativeMethodInfoPtr__execute_b__14_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00006445 File Offset: 0x00004645
		public RunVFXKabbage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x00026D40 File Offset: 0x00024F40
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x0000644E File Offset: 0x0000464E
		public unsafe FlavoredVFXMoveContext moveContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_moveContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredVFXMoveContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_moveContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00026D70 File Offset: 0x00024F70
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x0000646D File Offset: 0x0000466D
		public unsafe EntityComponent fxData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_fxData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_fxData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00026DA0 File Offset: 0x00024FA0
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x0000648C File Offset: 0x0000468C
		public unsafe int numUnits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_numUnits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_numUnits)) = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00026DC8 File Offset: 0x00024FC8
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x000064A7 File Offset: 0x000046A7
		public unsafe List<VoodooRenderAnimator> myKabbages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_myKabbages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VoodooRenderAnimator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_myKabbages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00026DF8 File Offset: 0x00024FF8
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x000064C6 File Offset: 0x000046C6
		public unsafe int numUnblocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_numUnblocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_numUnblocked)) = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00026E20 File Offset: 0x00025020
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x000064E1 File Offset: 0x000046E1
		public unsafe int numCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_numCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_numCompleted)) = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x00026E48 File Offset: 0x00025048
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x000064FC File Offset: 0x000046FC
		public unsafe bool useFXUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_useFXUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_useFXUnit)) = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00026E70 File Offset: 0x00025070
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00006517 File Offset: 0x00004717
		public unsafe PoolManager poolManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_poolManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_poolManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00026EA0 File Offset: 0x000250A0
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x00006536 File Offset: 0x00004736
		public unsafe ViewManager viewManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_viewManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr_viewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00026ED0 File Offset: 0x000250D0
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00006555 File Offset: 0x00004755
		public unsafe bool _Interrupted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr__Interrupted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.NativeFieldInfoPtr__Interrupted_k__BackingField)) = value;
			}
		}

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeFieldInfoPtr_moveContext;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeFieldInfoPtr_fxData;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeFieldInfoPtr_numUnits;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeFieldInfoPtr_myKabbages;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeFieldInfoPtr_numUnblocked;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr_numCompleted;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeFieldInfoPtr_useFXUnit;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeFieldInfoPtr_poolManager;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeFieldInfoPtr_viewManager;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeFieldInfoPtr__Interrupted_k__BackingField;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_get_AllComplete_Private_get_Boolean_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FlavoredVFXMoveContext_EntityComponent_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_VoodooRenderAnimator_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Void_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_TriggerOutro_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_get_Interrupted_Public_get_Boolean_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_set_Interrupted_Private_set_Void_Boolean_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__14_0_Private_Void_0;

		// Token: 0x02000111 RID: 273
		[ObfuscatedName("boardgames.kabbage.RunVFXKabbage+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x06000E2B RID: 3627 RVA: 0x00036E18 File Offset: 0x00035018
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<RunVFXKabbage.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunVFXKabbage.__c__DisplayClass14_0>.NativeClassPtr);
				RunVFXKabbage.__c__DisplayClass14_0.NativeFieldInfoPtr_kabbage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage.__c__DisplayClass14_0>.NativeClassPtr, "kabbage");
				RunVFXKabbage.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				RunVFXKabbage.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage.__c__DisplayClass14_0>.NativeClassPtr, 100664573);
				RunVFXKabbage.__c__DisplayClass14_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage.__c__DisplayClass14_0>.NativeClassPtr, 100664574);
			}

			// Token: 0x06000E2C RID: 3628 RVA: 0x00036E94 File Offset: 0x00035094
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunVFXKabbage.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E2D RID: 3629 RVA: 0x00036ED0 File Offset: 0x000350D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116613, XrefRangeEnd = 1116629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage.__c__DisplayClass14_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E2E RID: 3630 RVA: 0x000090BA File Offset: 0x000072BA
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000446 RID: 1094
			// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00036F04 File Offset: 0x00035104
			// (set) Token: 0x06000E30 RID: 3632 RVA: 0x000090C3 File Offset: 0x000072C3
			public unsafe VoodooRenderAnimator kabbage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.__c__DisplayClass14_0.NativeFieldInfoPtr_kabbage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooRenderAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.__c__DisplayClass14_0.NativeFieldInfoPtr_kabbage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000447 RID: 1095
			// (get) Token: 0x06000E31 RID: 3633 RVA: 0x00036F34 File Offset: 0x00035134
			// (set) Token: 0x06000E32 RID: 3634 RVA: 0x000090E2 File Offset: 0x000072E2
			public unsafe RunVFXKabbage __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunVFXKabbage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008CB RID: 2251
			private static readonly IntPtr NativeFieldInfoPtr_kabbage;

			// Token: 0x040008CC RID: 2252
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008CD RID: 2253
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040008CE RID: 2254
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Void_0;
		}

		// Token: 0x02000112 RID: 274
		[ObfuscatedName("boardgames.kabbage.RunVFXKabbage+<execute>d__14")]
		public sealed class _execute_d__14 : Object
		{
			// Token: 0x06000E33 RID: 3635 RVA: 0x00036F64 File Offset: 0x00035164
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__14()
			{
				Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunVFXKabbage>.NativeClassPtr, "<execute>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr);
				RunVFXKabbage._execute_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr, "<>1__state");
				RunVFXKabbage._execute_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr, "<>2__current");
				RunVFXKabbage._execute_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr, "<>4__this");
				RunVFXKabbage._execute_d__14.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr, "<>7__wrap1");
				RunVFXKabbage._execute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr, 100664575);
				RunVFXKabbage._execute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr, 100664576);
				RunVFXKabbage._execute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr, 100664577);
				RunVFXKabbage._execute_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr, 100664578);
				RunVFXKabbage._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr, 100664579);
				RunVFXKabbage._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr, 100664580);
				RunVFXKabbage._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr, 100664581);
			}

			// Token: 0x06000E34 RID: 3636 RVA: 0x0003706C File Offset: 0x0003526C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunVFXKabbage._execute_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage._execute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E35 RID: 3637 RVA: 0x000370B4 File Offset: 0x000352B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116629, XrefRangeEnd = 1116634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage._execute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E36 RID: 3638 RVA: 0x000370E8 File Offset: 0x000352E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116634, XrefRangeEnd = 1116763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage._execute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E37 RID: 3639 RVA: 0x00037124 File Offset: 0x00035324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116763, XrefRangeEnd = 1116766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage._execute_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700044C RID: 1100
			// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00037158 File Offset: 0x00035358
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E39 RID: 3641 RVA: 0x00037198 File Offset: 0x00035398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116766, XrefRangeEnd = 1116771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700044D RID: 1101
			// (get) Token: 0x06000E3A RID: 3642 RVA: 0x000371CC File Offset: 0x000353CC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunVFXKabbage._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E3B RID: 3643 RVA: 0x00009101 File Offset: 0x00007301
			public _execute_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000448 RID: 1096
			// (get) Token: 0x06000E3C RID: 3644 RVA: 0x0003720C File Offset: 0x0003540C
			// (set) Token: 0x06000E3D RID: 3645 RVA: 0x0000910A File Offset: 0x0000730A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage._execute_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage._execute_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000449 RID: 1097
			// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00037234 File Offset: 0x00035434
			// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00009125 File Offset: 0x00007325
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage._execute_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage._execute_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700044A RID: 1098
			// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00037264 File Offset: 0x00035464
			// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00009144 File Offset: 0x00007344
			public unsafe RunVFXKabbage __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage._execute_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunVFXKabbage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage._execute_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700044B RID: 1099
			// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00037294 File Offset: 0x00035494
			// (set) Token: 0x06000E43 RID: 3651 RVA: 0x00009163 File Offset: 0x00007363
			public List<UnitView>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage._execute_d__14.NativeFieldInfoPtr___7__wrap1);
					return new List<UnitView>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<UnitView>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunVFXKabbage._execute_d__14.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<UnitView>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040008CF RID: 2255
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040008D0 RID: 2256
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040008D1 RID: 2257
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008D2 RID: 2258
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040008D3 RID: 2259
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040008D4 RID: 2260
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008D5 RID: 2261
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008D6 RID: 2262
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040008D7 RID: 2263
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040008D8 RID: 2264
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008D9 RID: 2265
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
