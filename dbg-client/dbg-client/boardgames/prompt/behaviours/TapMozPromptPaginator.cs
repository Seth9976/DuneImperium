using System;
using boardgames.moz;
using Canis.utils.ids;
using dwd.core.animation;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.prompt.behaviours
{
	// Token: 0x02000106 RID: 262
	public class TapMozPromptPaginator : MonoBehaviour
	{
		// Token: 0x06000B8D RID: 2957 RVA: 0x00042194 File Offset: 0x00040394
		// Note: this type is marked as 'beforefieldinit'.
		static TapMozPromptPaginator()
		{
			Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.prompt.behaviours", "TapMozPromptPaginator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr);
			TapMozPromptPaginator.NativeFieldInfoPtr_downPageButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, "downPageButton");
			TapMozPromptPaginator.NativeFieldInfoPtr_upPageButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, "upPageButton");
			TapMozPromptPaginator.NativeFieldInfoPtr_preSwapAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, "preSwapAnimation");
			TapMozPromptPaginator.NativeFieldInfoPtr_postSwapAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, "postSwapAnimation");
			TapMozPromptPaginator.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, "prompt");
			TapMozPromptPaginator.NativeFieldInfoPtr_paginationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, "paginationList");
			TapMozPromptPaginator.NativeFieldInfoPtr_swapToEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, "swapToEntity");
			TapMozPromptPaginator.NativeFieldInfoPtr_lastParentViewsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, "lastParentViewsCount");
			TapMozPromptPaginator.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, 100664977);
			TapMozPromptPaginator.NativeMethodInfoPtr_ChangeEntity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, 100664978);
			TapMozPromptPaginator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, 100664979);
			TapMozPromptPaginator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, 100664980);
			TapMozPromptPaginator.NativeMethodInfoPtr__Start_b__8_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, 100664981);
			TapMozPromptPaginator.NativeMethodInfoPtr__Start_b__8_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, 100664982);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000422DC File Offset: 0x000404DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508667, XrefRangeEnd = 508672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0004231C File Offset: 0x0004051C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 508717, RefRangeEnd = 508719, XrefRangeStart = 508672, XrefRangeEnd = 508717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeEntity(int direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator.NativeMethodInfoPtr_ChangeEntity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0004235C File Offset: 0x0004055C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508719, XrefRangeEnd = 508754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00042390 File Offset: 0x00040590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508754, XrefRangeEnd = 508755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TapMozPromptPaginator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000423CC File Offset: 0x000405CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508755, XrefRangeEnd = 508756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__8_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator.NativeMethodInfoPtr__Start_b__8_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00042400 File Offset: 0x00040600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508756, XrefRangeEnd = 508757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__8_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator.NativeMethodInfoPtr__Start_b__8_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0000786A File Offset: 0x00005A6A
		public TapMozPromptPaginator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x00042434 File Offset: 0x00040634
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x00007873 File Offset: 0x00005A73
		public unsafe Button downPageButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_downPageButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_downPageButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00042464 File Offset: 0x00040664
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x00007892 File Offset: 0x00005A92
		public unsafe Button upPageButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_upPageButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_upPageButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00042494 File Offset: 0x00040694
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x000078B1 File Offset: 0x00005AB1
		public unsafe TriggeredBlockingAnimation preSwapAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_preSwapAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_preSwapAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x000424C4 File Offset: 0x000406C4
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x000078D0 File Offset: 0x00005AD0
		public unsafe TriggeredBlockingAnimation postSwapAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_postSwapAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_postSwapAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x000424F4 File Offset: 0x000406F4
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x000078EF File Offset: 0x00005AEF
		public unsafe TapMozPromptBehaviour prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TapMozPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00042524 File Offset: 0x00040724
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x0000790E File Offset: 0x00005B0E
		public unsafe ITapMozPaginationList paginationList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_paginationList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITapMozPaginationList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_paginationList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x00042554 File Offset: 0x00040754
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x0000792D File Offset: 0x00005B2D
		public unsafe EntityComponent swapToEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_swapToEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_swapToEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00042584 File Offset: 0x00040784
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x0000794C File Offset: 0x00005B4C
		public unsafe int lastParentViewsCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_lastParentViewsCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.NativeFieldInfoPtr_lastParentViewsCount)) = value;
			}
		}

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr_downPageButton;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_upPageButton;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_preSwapAnimation;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_postSwapAnimation;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_paginationList;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_swapToEntity;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_lastParentViewsCount;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEntity_Private_Void_Int32_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__8_0_Private_Void_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__8_1_Private_Void_0;

		// Token: 0x02000344 RID: 836
		[ObfuscatedName("boardgames.prompt.behaviours.TapMozPromptPaginator+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002789 RID: 10121 RVA: 0x0009EBC0 File Offset: 0x0009CDC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<TapMozPromptPaginator.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TapMozPromptPaginator.__c__DisplayClass9_0>.NativeClassPtr);
				TapMozPromptPaginator.__c__DisplayClass9_0.NativeFieldInfoPtr_displayedId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptPaginator.__c__DisplayClass9_0>.NativeClassPtr, "displayedId");
				TapMozPromptPaginator.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator.__c__DisplayClass9_0>.NativeClassPtr, 100664983);
				TapMozPromptPaginator.__c__DisplayClass9_0.NativeMethodInfoPtr__ChangeEntity_b__0_Internal_Boolean_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator.__c__DisplayClass9_0>.NativeClassPtr, 100664984);
			}

			// Token: 0x0600278A RID: 10122 RVA: 0x0009EC28 File Offset: 0x0009CE28
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TapMozPromptPaginator.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600278B RID: 10123 RVA: 0x0009EC64 File Offset: 0x0009CE64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508643, XrefRangeEnd = 508649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChangeEntity_b__0(EntityView v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator.__c__DisplayClass9_0.NativeMethodInfoPtr__ChangeEntity_b__0_Internal_Boolean_EntityView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600278C RID: 10124 RVA: 0x000147F6 File Offset: 0x000129F6
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B07 RID: 2823
			// (get) Token: 0x0600278D RID: 10125 RVA: 0x0009ECB4 File Offset: 0x0009CEB4
			// (set) Token: 0x0600278E RID: 10126 RVA: 0x000147FF File Offset: 0x000129FF
			public unsafe EntityID displayedId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.__c__DisplayClass9_0.NativeFieldInfoPtr_displayedId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator.__c__DisplayClass9_0.NativeFieldInfoPtr_displayedId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018CB RID: 6347
			private static readonly IntPtr NativeFieldInfoPtr_displayedId;

			// Token: 0x040018CC RID: 6348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018CD RID: 6349
			private static readonly IntPtr NativeMethodInfoPtr__ChangeEntity_b__0_Internal_Boolean_EntityView_0;
		}

		// Token: 0x02000345 RID: 837
		[ObfuscatedName("boardgames.prompt.behaviours.TapMozPromptPaginator+<Start>d__8")]
		public sealed class _Start_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x0600278F RID: 10127 RVA: 0x0009ECE4 File Offset: 0x0009CEE4
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__8()
			{
				Il2CppClassPointerStore<TapMozPromptPaginator._Start_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TapMozPromptPaginator>.NativeClassPtr, "<Start>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TapMozPromptPaginator._Start_d__8>.NativeClassPtr);
				TapMozPromptPaginator._Start_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptPaginator._Start_d__8>.NativeClassPtr, "<>1__state");
				TapMozPromptPaginator._Start_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptPaginator._Start_d__8>.NativeClassPtr, "<>2__current");
				TapMozPromptPaginator._Start_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptPaginator._Start_d__8>.NativeClassPtr, "<>4__this");
				TapMozPromptPaginator._Start_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator._Start_d__8>.NativeClassPtr, 100664985);
				TapMozPromptPaginator._Start_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator._Start_d__8>.NativeClassPtr, 100664986);
				TapMozPromptPaginator._Start_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator._Start_d__8>.NativeClassPtr, 100664987);
				TapMozPromptPaginator._Start_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator._Start_d__8>.NativeClassPtr, 100664988);
				TapMozPromptPaginator._Start_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator._Start_d__8>.NativeClassPtr, 100664989);
				TapMozPromptPaginator._Start_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptPaginator._Start_d__8>.NativeClassPtr, 100664990);
			}

			// Token: 0x06002790 RID: 10128 RVA: 0x0009EDC4 File Offset: 0x0009CFC4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TapMozPromptPaginator._Start_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator._Start_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002791 RID: 10129 RVA: 0x0009EE0C File Offset: 0x0009D00C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator._Start_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002792 RID: 10130 RVA: 0x0009EE40 File Offset: 0x0009D040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508649, XrefRangeEnd = 508662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator._Start_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B0B RID: 2827
			// (get) Token: 0x06002793 RID: 10131 RVA: 0x0009EE7C File Offset: 0x0009D07C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator._Start_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002794 RID: 10132 RVA: 0x0009EEBC File Offset: 0x0009D0BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508662, XrefRangeEnd = 508667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator._Start_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B0C RID: 2828
			// (get) Token: 0x06002795 RID: 10133 RVA: 0x0009EEF0 File Offset: 0x0009D0F0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptPaginator._Start_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002796 RID: 10134 RVA: 0x0001481E File Offset: 0x00012A1E
			public _Start_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B08 RID: 2824
			// (get) Token: 0x06002797 RID: 10135 RVA: 0x0009EF30 File Offset: 0x0009D130
			// (set) Token: 0x06002798 RID: 10136 RVA: 0x00014827 File Offset: 0x00012A27
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator._Start_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator._Start_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B09 RID: 2825
			// (get) Token: 0x06002799 RID: 10137 RVA: 0x0009EF58 File Offset: 0x0009D158
			// (set) Token: 0x0600279A RID: 10138 RVA: 0x00014842 File Offset: 0x00012A42
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator._Start_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator._Start_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B0A RID: 2826
			// (get) Token: 0x0600279B RID: 10139 RVA: 0x0009EF88 File Offset: 0x0009D188
			// (set) Token: 0x0600279C RID: 10140 RVA: 0x00014861 File Offset: 0x00012A61
			public unsafe TapMozPromptPaginator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator._Start_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TapMozPromptPaginator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptPaginator._Start_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018CE RID: 6350
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018CF RID: 6351
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018D0 RID: 6352
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018D1 RID: 6353
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018D2 RID: 6354
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018D3 RID: 6355
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018D4 RID: 6356
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018D5 RID: 6357
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018D6 RID: 6358
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
