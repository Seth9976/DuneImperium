using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace lotus.src.ui.commands
{
	// Token: 0x020000ED RID: 237
	public class AnimateCanvasGroupAlpha : Command
	{
		// Token: 0x06000B74 RID: 2932 RVA: 0x00035A5C File Offset: 0x00033C5C
		// Note: this type is marked as 'beforefieldinit'.
		static AnimateCanvasGroupAlpha()
		{
			Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.ui.commands", "AnimateCanvasGroupAlpha");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr);
			AnimateCanvasGroupAlpha.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr, "canvas");
			AnimateCanvasGroupAlpha.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr, "duration");
			AnimateCanvasGroupAlpha.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr, "target");
			AnimateCanvasGroupAlpha.NativeFieldInfoPtr_startDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr, "startDelay");
			AnimateCanvasGroupAlpha.NativeFieldInfoPtr_startingAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr, "startingAlpha");
			AnimateCanvasGroupAlpha.NativeFieldInfoPtr_hasStartingAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr, "hasStartingAlpha");
			AnimateCanvasGroupAlpha.NativeFieldInfoPtr_Running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr, "Running");
			AnimateCanvasGroupAlpha.NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr, 100665124);
			AnimateCanvasGroupAlpha.NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr, 100665125);
			AnimateCanvasGroupAlpha.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr, 100665126);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00035B54 File Offset: 0x00033D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994728, XrefRangeEnd = 994730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimateCanvasGroupAlpha(CanvasGroup canvas, float duration, float startDelay, float target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateCanvasGroupAlpha.NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00035BCC File Offset: 0x00033DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994730, XrefRangeEnd = 994732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimateCanvasGroupAlpha(CanvasGroup canvas, float duration, float startDelay, float start, float target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateCanvasGroupAlpha.NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00035C50 File Offset: 0x00033E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994732, XrefRangeEnd = 994737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimateCanvasGroupAlpha.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0000734C File Offset: 0x0000554C
		public AnimateCanvasGroupAlpha(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00035C9C File Offset: 0x00033E9C
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x00007355 File Offset: 0x00005555
		public unsafe CanvasGroup canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00035CCC File Offset: 0x00033ECC
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00007374 File Offset: 0x00005574
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00035CF4 File Offset: 0x00033EF4
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x0000738F File Offset: 0x0000558F
		public unsafe float target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_target);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_target)) = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00035D1C File Offset: 0x00033F1C
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x000073AA File Offset: 0x000055AA
		public unsafe float startDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_startDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_startDelay)) = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00035D44 File Offset: 0x00033F44
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x000073C5 File Offset: 0x000055C5
		public unsafe float startingAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_startingAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_startingAlpha)) = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00035D6C File Offset: 0x00033F6C
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x000073E0 File Offset: 0x000055E0
		public unsafe bool hasStartingAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_hasStartingAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_hasStartingAlpha)) = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00035D94 File Offset: 0x00033F94
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x000073FB File Offset: 0x000055FB
		public unsafe bool Running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_Running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha.NativeFieldInfoPtr_Running)) = value;
			}
		}

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_startDelay;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_startingAlpha;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_hasStartingAlpha;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_Running;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_Single_Single_Single_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CanvasGroup_Single_Single_Single_Single_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000243 RID: 579
		[ObfuscatedName("lotus.src.ui.commands.AnimateCanvasGroupAlpha+<execute>d__9")]
		public sealed class _execute_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x06001AC7 RID: 6855 RVA: 0x00063C94 File Offset: 0x00061E94
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__9()
			{
				Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimateCanvasGroupAlpha>.NativeClassPtr, "<execute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr);
				AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr, "<>1__state");
				AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr, "<>2__current");
				AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr, "<>4__this");
				AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr__start_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr, "<start>5__2");
				AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr__startTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr, "<startTime>5__3");
				AnimateCanvasGroupAlpha._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr, 100665127);
				AnimateCanvasGroupAlpha._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr, 100665128);
				AnimateCanvasGroupAlpha._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr, 100665129);
				AnimateCanvasGroupAlpha._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr, 100665130);
				AnimateCanvasGroupAlpha._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr, 100665131);
				AnimateCanvasGroupAlpha._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr, 100665132);
			}

			// Token: 0x06001AC8 RID: 6856 RVA: 0x00063D9C File Offset: 0x00061F9C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimateCanvasGroupAlpha._execute_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateCanvasGroupAlpha._execute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AC9 RID: 6857 RVA: 0x00063DE4 File Offset: 0x00061FE4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateCanvasGroupAlpha._execute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ACA RID: 6858 RVA: 0x00063E18 File Offset: 0x00062018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994712, XrefRangeEnd = 994723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateCanvasGroupAlpha._execute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007DF RID: 2015
			// (get) Token: 0x06001ACB RID: 6859 RVA: 0x00063E54 File Offset: 0x00062054
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateCanvasGroupAlpha._execute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001ACC RID: 6860 RVA: 0x00063E94 File Offset: 0x00062094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994723, XrefRangeEnd = 994728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateCanvasGroupAlpha._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007E0 RID: 2016
			// (get) Token: 0x06001ACD RID: 6861 RVA: 0x00063EC8 File Offset: 0x000620C8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateCanvasGroupAlpha._execute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001ACE RID: 6862 RVA: 0x0000E907 File Offset: 0x0000CB07
			public _execute_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007DA RID: 2010
			// (get) Token: 0x06001ACF RID: 6863 RVA: 0x00063F08 File Offset: 0x00062108
			// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x0000E910 File Offset: 0x0000CB10
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007DB RID: 2011
			// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x00063F30 File Offset: 0x00062130
			// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x0000E92B File Offset: 0x0000CB2B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007DC RID: 2012
			// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x00063F60 File Offset: 0x00062160
			// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x0000E94A File Offset: 0x0000CB4A
			public unsafe AnimateCanvasGroupAlpha __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimateCanvasGroupAlpha>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007DD RID: 2013
			// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x00063F90 File Offset: 0x00062190
			// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x0000E969 File Offset: 0x0000CB69
			public unsafe float _start_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr__start_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr__start_5__2)) = value;
				}
			}

			// Token: 0x170007DE RID: 2014
			// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x00063FB8 File Offset: 0x000621B8
			// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x0000E984 File Offset: 0x0000CB84
			public unsafe float _startTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr__startTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateCanvasGroupAlpha._execute_d__9.NativeFieldInfoPtr__startTime_5__3)) = value;
				}
			}

			// Token: 0x04001030 RID: 4144
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001031 RID: 4145
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001032 RID: 4146
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001033 RID: 4147
			private static readonly IntPtr NativeFieldInfoPtr__start_5__2;

			// Token: 0x04001034 RID: 4148
			private static readonly IntPtr NativeFieldInfoPtr__startTime_5__3;

			// Token: 0x04001035 RID: 4149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001036 RID: 4150
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001037 RID: 4151
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001038 RID: 4152
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001039 RID: 4153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400103A RID: 4154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
