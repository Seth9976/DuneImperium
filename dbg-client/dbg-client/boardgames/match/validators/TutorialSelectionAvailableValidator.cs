using System;
using boardgames.match.behaviours;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.match.validators
{
	// Token: 0x02000252 RID: 594
	public class TutorialSelectionAvailableValidator : SelectableChildValidator
	{
		// Token: 0x06001B12 RID: 6930 RVA: 0x00075BFC File Offset: 0x00073DFC
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialSelectionAvailableValidator()
		{
			Il2CppClassPointerStore<TutorialSelectionAvailableValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.validators", "TutorialSelectionAvailableValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSelectionAvailableValidator>.NativeClassPtr);
			TutorialSelectionAvailableValidator.NativeFieldInfoPtr_isTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectionAvailableValidator>.NativeClassPtr, "isTutorial");
			TutorialSelectionAvailableValidator.NativeMethodInfoPtr_Start_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectionAvailableValidator>.NativeClassPtr, 100667611);
			TutorialSelectionAvailableValidator.NativeMethodInfoPtr_isValid_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectionAvailableValidator>.NativeClassPtr, 100667612);
			TutorialSelectionAvailableValidator.NativeMethodInfoPtr_tutorialPromptAllowsSelection_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectionAvailableValidator>.NativeClassPtr, 100667613);
			TutorialSelectionAvailableValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectionAvailableValidator>.NativeClassPtr, 100667614);
			TutorialSelectionAvailableValidator.NativeMethodInfoPtr___n__0_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectionAvailableValidator>.NativeClassPtr, 100667615);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x00075CA4 File Offset: 0x00073EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532941, XrefRangeEnd = 532946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialSelectionAvailableValidator.NativeMethodInfoPtr_Start_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x00075CF0 File Offset: 0x00073EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532946, XrefRangeEnd = 532947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool isValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialSelectionAvailableValidator.NativeMethodInfoPtr_isValid_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x00075D38 File Offset: 0x00073F38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 532981, RefRangeEnd = 532982, XrefRangeStart = 532947, XrefRangeEnd = 532981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool tutorialPromptAllowsSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectionAvailableValidator.NativeMethodInfoPtr_tutorialPromptAllowsSelection_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x00075D74 File Offset: 0x00073F74
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialSelectionAvailableValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialSelectionAvailableValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectionAvailableValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x00075DB0 File Offset: 0x00073FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectionAvailableValidator.NativeMethodInfoPtr___n__0_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0000EC63 File Offset: 0x0000CE63
		public TutorialSelectionAvailableValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x00075DF0 File Offset: 0x00073FF0
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x0000EC6C File Offset: 0x0000CE6C
		public unsafe bool isTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectionAvailableValidator.NativeFieldInfoPtr_isTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectionAvailableValidator.NativeFieldInfoPtr_isTutorial)) = value;
			}
		}

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeFieldInfoPtr_isTutorial;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_IEnumerator_0;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_isValid_Protected_Virtual_Boolean_0;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_tutorialPromptAllowsSelection_Private_Boolean_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_0;

		// Token: 0x02000441 RID: 1089
		[ObfuscatedName("boardgames.match.validators.TutorialSelectionAvailableValidator+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003380 RID: 13184 RVA: 0x000C22A4 File Offset: 0x000C04A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TutorialSelectionAvailableValidator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSelectionAvailableValidator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSelectionAvailableValidator.__c>.NativeClassPtr);
				TutorialSelectionAvailableValidator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectionAvailableValidator.__c>.NativeClassPtr, "<>9");
				TutorialSelectionAvailableValidator.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectionAvailableValidator.__c>.NativeClassPtr, "<>9__3_0");
				TutorialSelectionAvailableValidator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectionAvailableValidator.__c>.NativeClassPtr, 100667617);
				TutorialSelectionAvailableValidator.__c.NativeMethodInfoPtr__tutorialPromptAllowsSelection_b__3_0_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectionAvailableValidator.__c>.NativeClassPtr, 100667618);
			}

			// Token: 0x06003381 RID: 13185 RVA: 0x000C2320 File Offset: 0x000C0520
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialSelectionAvailableValidator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectionAvailableValidator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003382 RID: 13186 RVA: 0x000C235C File Offset: 0x000C055C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532933, XrefRangeEnd = 532934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _tutorialPromptAllowsSelection_b__3_0(Command command)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectionAvailableValidator.__c.NativeMethodInfoPtr__tutorialPromptAllowsSelection_b__3_0_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003383 RID: 13187 RVA: 0x0001A96A File Offset: 0x00018B6A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F08 RID: 3848
			// (get) Token: 0x06003384 RID: 13188 RVA: 0x000C23AC File Offset: 0x000C05AC
			// (set) Token: 0x06003385 RID: 13189 RVA: 0x0001A973 File Offset: 0x00018B73
			public unsafe static TutorialSelectionAvailableValidator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialSelectionAvailableValidator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialSelectionAvailableValidator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialSelectionAvailableValidator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F09 RID: 3849
			// (get) Token: 0x06003386 RID: 13190 RVA: 0x000C23D4 File Offset: 0x000C05D4
			// (set) Token: 0x06003387 RID: 13191 RVA: 0x0001A985 File Offset: 0x00018B85
			public unsafe static Func<Command, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialSelectionAvailableValidator.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialSelectionAvailableValidator.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FC3 RID: 8131
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001FC4 RID: 8132
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001FC5 RID: 8133
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FC6 RID: 8134
			private static readonly IntPtr NativeMethodInfoPtr__tutorialPromptAllowsSelection_b__3_0_Internal_Boolean_Command_0;
		}

		// Token: 0x02000442 RID: 1090
		[ObfuscatedName("boardgames.match.validators.TutorialSelectionAvailableValidator+<Start>d__1")]
		public sealed class _Start_d__1 : Object
		{
			// Token: 0x06003388 RID: 13192 RVA: 0x000C23FC File Offset: 0x000C05FC
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__1()
			{
				Il2CppClassPointerStore<TutorialSelectionAvailableValidator._Start_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialSelectionAvailableValidator>.NativeClassPtr, "<Start>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSelectionAvailableValidator._Start_d__1>.NativeClassPtr);
				TutorialSelectionAvailableValidator._Start_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectionAvailableValidator._Start_d__1>.NativeClassPtr, "<>1__state");
				TutorialSelectionAvailableValidator._Start_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectionAvailableValidator._Start_d__1>.NativeClassPtr, "<>2__current");
				TutorialSelectionAvailableValidator._Start_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectionAvailableValidator._Start_d__1>.NativeClassPtr, "<>4__this");
				TutorialSelectionAvailableValidator._Start_d__1.NativeFieldInfoPtr__matchHub_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSelectionAvailableValidator._Start_d__1>.NativeClassPtr, "<matchHub>5__2");
				TutorialSelectionAvailableValidator._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectionAvailableValidator._Start_d__1>.NativeClassPtr, 100667619);
				TutorialSelectionAvailableValidator._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectionAvailableValidator._Start_d__1>.NativeClassPtr, 100667620);
				TutorialSelectionAvailableValidator._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectionAvailableValidator._Start_d__1>.NativeClassPtr, 100667621);
				TutorialSelectionAvailableValidator._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectionAvailableValidator._Start_d__1>.NativeClassPtr, 100667622);
				TutorialSelectionAvailableValidator._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectionAvailableValidator._Start_d__1>.NativeClassPtr, 100667623);
				TutorialSelectionAvailableValidator._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSelectionAvailableValidator._Start_d__1>.NativeClassPtr, 100667624);
			}

			// Token: 0x06003389 RID: 13193 RVA: 0x000C24F0 File Offset: 0x000C06F0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialSelectionAvailableValidator._Start_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectionAvailableValidator._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600338A RID: 13194 RVA: 0x000C2538 File Offset: 0x000C0738
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectionAvailableValidator._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600338B RID: 13195 RVA: 0x000C256C File Offset: 0x000C076C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532934, XrefRangeEnd = 532936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectionAvailableValidator._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F0E RID: 3854
			// (get) Token: 0x0600338C RID: 13196 RVA: 0x000C25A8 File Offset: 0x000C07A8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectionAvailableValidator._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600338D RID: 13197 RVA: 0x000C25E8 File Offset: 0x000C07E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532936, XrefRangeEnd = 532941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectionAvailableValidator._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F0F RID: 3855
			// (get) Token: 0x0600338E RID: 13198 RVA: 0x000C261C File Offset: 0x000C081C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSelectionAvailableValidator._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600338F RID: 13199 RVA: 0x0001A997 File Offset: 0x00018B97
			public _Start_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F0A RID: 3850
			// (get) Token: 0x06003390 RID: 13200 RVA: 0x000C265C File Offset: 0x000C085C
			// (set) Token: 0x06003391 RID: 13201 RVA: 0x0001A9A0 File Offset: 0x00018BA0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectionAvailableValidator._Start_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectionAvailableValidator._Start_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F0B RID: 3851
			// (get) Token: 0x06003392 RID: 13202 RVA: 0x000C2684 File Offset: 0x000C0884
			// (set) Token: 0x06003393 RID: 13203 RVA: 0x0001A9BB File Offset: 0x00018BBB
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectionAvailableValidator._Start_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectionAvailableValidator._Start_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F0C RID: 3852
			// (get) Token: 0x06003394 RID: 13204 RVA: 0x000C26B4 File Offset: 0x000C08B4
			// (set) Token: 0x06003395 RID: 13205 RVA: 0x0001A9DA File Offset: 0x00018BDA
			public unsafe TutorialSelectionAvailableValidator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectionAvailableValidator._Start_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialSelectionAvailableValidator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectionAvailableValidator._Start_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F0D RID: 3853
			// (get) Token: 0x06003396 RID: 13206 RVA: 0x000C26E4 File Offset: 0x000C08E4
			// (set) Token: 0x06003397 RID: 13207 RVA: 0x0001A9F9 File Offset: 0x00018BF9
			public unsafe DBGMatchHub _matchHub_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectionAvailableValidator._Start_d__1.NativeFieldInfoPtr__matchHub_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialSelectionAvailableValidator._Start_d__1.NativeFieldInfoPtr__matchHub_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FC7 RID: 8135
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FC8 RID: 8136
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001FC9 RID: 8137
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FCA RID: 8138
			private static readonly IntPtr NativeFieldInfoPtr__matchHub_5__2;

			// Token: 0x04001FCB RID: 8139
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001FCC RID: 8140
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FCD RID: 8141
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001FCE RID: 8142
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001FCF RID: 8143
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FD0 RID: 8144
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
