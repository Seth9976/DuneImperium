using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.ui.ugui.commands
{
	// Token: 0x02000019 RID: 25
	public class FadeCanvasGroup : Command
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00006144 File Offset: 0x00004344
		// Note: this type is marked as 'beforefieldinit'.
		static FadeCanvasGroup()
		{
			Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.ui.ugui.commands", "FadeCanvasGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr);
			FadeCanvasGroup.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr, "CanvasGroup");
			FadeCanvasGroup.NativeFieldInfoPtr_FadeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr, "FadeType");
			FadeCanvasGroup.NativeFieldInfoPtr_DurationSecs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr, "DurationSecs");
			FadeCanvasGroup.NativeFieldInfoPtr_getTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr, "getTime");
			FadeCanvasGroup.NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_FadeTypes_Single_Func_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr, 100663430);
			FadeCanvasGroup.NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_FadeTypes_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr, 100663431);
			FadeCanvasGroup.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr, 100663432);
			FadeCanvasGroup.NativeMethodInfoPtr__execute_b__7_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr, 100663433);
			FadeCanvasGroup.NativeMethodInfoPtr__execute_b__7_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr, 100663434);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00006228 File Offset: 0x00004428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254511, XrefRangeEnd = 1254514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FadeCanvasGroup(CanvasGroup canvasGroup, FadeCanvasGroup.FadeTypes fadeType, float durationSecs, Func<float> getTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSecs;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getTime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadeCanvasGroup.NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_FadeTypes_Single_Func_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000062A4 File Offset: 0x000044A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254514, XrefRangeEnd = 1254532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FadeCanvasGroup(CanvasGroup canvasGroup, FadeCanvasGroup.FadeTypes fadeType, float durationSecs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSecs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadeCanvasGroup.NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_FadeTypes_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000630C File Offset: 0x0000450C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254532, XrefRangeEnd = 1254547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FadeCanvasGroup.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00006358 File Offset: 0x00004558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__7_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadeCanvasGroup.NativeMethodInfoPtr__execute_b__7_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00006398 File Offset: 0x00004598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254547, XrefRangeEnd = 1254549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__7_1(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadeCanvasGroup.NativeMethodInfoPtr__execute_b__7_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002751 File Offset: 0x00000951
		public FadeCanvasGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000063D8 File Offset: 0x000045D8
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000275A File Offset: 0x0000095A
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeCanvasGroup.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeCanvasGroup.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00006408 File Offset: 0x00004608
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002779 File Offset: 0x00000979
		public unsafe FadeCanvasGroup.FadeTypes FadeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeCanvasGroup.NativeFieldInfoPtr_FadeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeCanvasGroup.NativeFieldInfoPtr_FadeType)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00006430 File Offset: 0x00004630
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002794 File Offset: 0x00000994
		public unsafe float DurationSecs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeCanvasGroup.NativeFieldInfoPtr_DurationSecs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeCanvasGroup.NativeFieldInfoPtr_DurationSecs)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00006458 File Offset: 0x00004658
		// (set) Token: 0x06000115 RID: 277 RVA: 0x000027AF File Offset: 0x000009AF
		public unsafe Func<float> getTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeCanvasGroup.NativeFieldInfoPtr_getTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FadeCanvasGroup.NativeFieldInfoPtr_getTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_FadeType;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_DurationSecs;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_getTime;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_FadeTypes_Single_Func_1_Single_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_FadeTypes_Single_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__7_0_Private_Void_Single_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__7_1_Private_Void_Single_0;

		// Token: 0x02000027 RID: 39
		public enum FadeTypes
		{
			// Token: 0x040000E4 RID: 228
			OpaqueToTransparent,
			// Token: 0x040000E5 RID: 229
			TransparentToOpaque
		}

		// Token: 0x02000028 RID: 40
		[ObfuscatedName("dwd.core.ui.ugui.commands.FadeCanvasGroup+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600017B RID: 379 RVA: 0x0000751C File Offset: 0x0000571C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FadeCanvasGroup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FadeCanvasGroup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadeCanvasGroup.__c>.NativeClassPtr);
				FadeCanvasGroup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeCanvasGroup.__c>.NativeClassPtr, "<>9");
				FadeCanvasGroup.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeCanvasGroup.__c>.NativeClassPtr, "<>9__6_0");
				FadeCanvasGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeCanvasGroup.__c>.NativeClassPtr, 100663436);
				FadeCanvasGroup.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeCanvasGroup.__c>.NativeClassPtr, 100663437);
			}

			// Token: 0x0600017C RID: 380 RVA: 0x00007598 File Offset: 0x00005798
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FadeCanvasGroup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadeCanvasGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600017D RID: 381 RVA: 0x000075D4 File Offset: 0x000057D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float __ctor_b__6_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FadeCanvasGroup.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600017E RID: 382 RVA: 0x00002B47 File Offset: 0x00000D47
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x0600017F RID: 383 RVA: 0x00007610 File Offset: 0x00005810
			// (set) Token: 0x06000180 RID: 384 RVA: 0x00002B50 File Offset: 0x00000D50
			public unsafe static FadeCanvasGroup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FadeCanvasGroup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FadeCanvasGroup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FadeCanvasGroup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000181 RID: 385 RVA: 0x00007638 File Offset: 0x00005838
			// (set) Token: 0x06000182 RID: 386 RVA: 0x00002B62 File Offset: 0x00000D62
			public unsafe static Func<float> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FadeCanvasGroup.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FadeCanvasGroup.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000E6 RID: 230
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000E7 RID: 231
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040000E8 RID: 232
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000E9 RID: 233
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__6_0_Internal_Single_0;
		}
	}
}
