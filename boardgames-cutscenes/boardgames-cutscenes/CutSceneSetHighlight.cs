using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using zen.src.match.monobehaviours;

namespace lotus
{
	// Token: 0x02000012 RID: 18
	public class CutSceneSetHighlight : CutSceneAction
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00004DEC File Offset: 0x00002FEC
		// Note: this type is marked as 'beforefieldinit'.
		static CutSceneSetHighlight()
		{
			Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "CutSceneSetHighlight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr);
			CutSceneSetHighlight.NativeFieldInfoPtr_fxName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr, "fxName");
			CutSceneSetHighlight.NativeFieldInfoPtr_isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr, "isVisible");
			CutSceneSetHighlight.NativeFieldInfoPtr_respondToInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr, "respondToInteraction");
			CutSceneSetHighlight.NativeFieldInfoPtr_EndSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr, "EndSignal");
			CutSceneSetHighlight.NativeMethodInfoPtr_Play_Public_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr, 100663419);
			CutSceneSetHighlight.NativeMethodInfoPtr_play_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr, 100663420);
			CutSceneSetHighlight.NativeMethodInfoPtr_SetVisible_Private_IEnumerator_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr, 100663421);
			CutSceneSetHighlight.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr, 100663422);
			CutSceneSetHighlight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr, 100663423);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004ED0 File Offset: 0x000030D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258461, XrefRangeEnd = 1258470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneSetHighlight.NativeMethodInfoPtr_Play_Public_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004F1C File Offset: 0x0000311C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258470, XrefRangeEnd = 1258475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight.NativeMethodInfoPtr_play_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004F5C File Offset: 0x0000315C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258480, RefRangeEnd = 1258481, XrefRangeStart = 1258475, XrefRangeEnd = 1258480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetVisible(bool visible, bool interaction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interaction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight.NativeMethodInfoPtr_SetVisible_Private_IEnumerator_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004FB8 File Offset: 0x000031B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258481, XrefRangeEnd = 1258490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneSetHighlight.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004FFC File Offset: 0x000031FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutSceneSetHighlight()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000023BA File Offset: 0x000005BA
		public CutSceneSetHighlight(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00005038 File Offset: 0x00003238
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000023C3 File Offset: 0x000005C3
		public unsafe string fxName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight.NativeFieldInfoPtr_fxName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight.NativeFieldInfoPtr_fxName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00005060 File Offset: 0x00003260
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000023E2 File Offset: 0x000005E2
		public unsafe bool isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight.NativeFieldInfoPtr_isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight.NativeFieldInfoPtr_isVisible)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00005088 File Offset: 0x00003288
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000023FD File Offset: 0x000005FD
		public unsafe bool respondToInteraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight.NativeFieldInfoPtr_respondToInteraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight.NativeFieldInfoPtr_respondToInteraction)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000050B0 File Offset: 0x000032B0
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002418 File Offset: 0x00000618
		public unsafe string EndSignal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight.NativeFieldInfoPtr_EndSignal);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight.NativeFieldInfoPtr_EndSignal), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_fxName;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_isVisible;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_respondToInteraction;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_EndSignal;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Command_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_play_Private_IEnumerator_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Private_IEnumerator_Boolean_Boolean_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200002A RID: 42
		[ObfuscatedName("lotus.CutSceneSetHighlight+<SetVisible>d__6")]
		public sealed class _SetVisible_d__6 : Object
		{
			// Token: 0x06000194 RID: 404 RVA: 0x00007F54 File Offset: 0x00006154
			// Note: this type is marked as 'beforefieldinit'.
			static _SetVisible_d__6()
			{
				Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr, "<SetVisible>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr);
				CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr, "<>1__state");
				CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr, "<>2__current");
				CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr, "<>4__this");
				CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr, "visible");
				CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr_interaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr, "interaction");
				CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr__hr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr, "<hr>5__2");
				CutSceneSetHighlight._SetVisible_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr, 100663424);
				CutSceneSetHighlight._SetVisible_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr, 100663425);
				CutSceneSetHighlight._SetVisible_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr, 100663426);
				CutSceneSetHighlight._SetVisible_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr, 100663427);
				CutSceneSetHighlight._SetVisible_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr, 100663428);
				CutSceneSetHighlight._SetVisible_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr, 100663429);
			}

			// Token: 0x06000195 RID: 405 RVA: 0x00008070 File Offset: 0x00006270
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetVisible_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneSetHighlight._SetVisible_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight._SetVisible_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000196 RID: 406 RVA: 0x000080B8 File Offset: 0x000062B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight._SetVisible_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000197 RID: 407 RVA: 0x000080EC File Offset: 0x000062EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258441, XrefRangeEnd = 1258447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight._SetVisible_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x06000198 RID: 408 RVA: 0x00008128 File Offset: 0x00006328
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight._SetVisible_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000199 RID: 409 RVA: 0x00008168 File Offset: 0x00006368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258447, XrefRangeEnd = 1258452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight._SetVisible_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x0600019A RID: 410 RVA: 0x0000819C File Offset: 0x0000639C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight._SetVisible_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600019B RID: 411 RVA: 0x00002AF9 File Offset: 0x00000CF9
			public _SetVisible_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x0600019C RID: 412 RVA: 0x000081DC File Offset: 0x000063DC
			// (set) Token: 0x0600019D RID: 413 RVA: 0x00002B02 File Offset: 0x00000D02
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x0600019E RID: 414 RVA: 0x00008204 File Offset: 0x00006404
			// (set) Token: 0x0600019F RID: 415 RVA: 0x00002B1D File Offset: 0x00000D1D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x060001A0 RID: 416 RVA: 0x00008234 File Offset: 0x00006434
			// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002B3C File Offset: 0x00000D3C
			public unsafe CutSceneSetHighlight __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutSceneSetHighlight>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x060001A2 RID: 418 RVA: 0x00008264 File Offset: 0x00006464
			// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002B5B File Offset: 0x00000D5B
			public unsafe bool visible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr_visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr_visible)) = value;
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000828C File Offset: 0x0000648C
			// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002B76 File Offset: 0x00000D76
			public unsafe bool interaction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr_interaction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr_interaction)) = value;
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x060001A6 RID: 422 RVA: 0x000082B4 File Offset: 0x000064B4
			// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002B91 File Offset: 0x00000D91
			public unsafe HighlightRenderer _hr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr__hr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HighlightRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._SetVisible_d__6.NativeFieldInfoPtr__hr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000F4 RID: 244
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000F5 RID: 245
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000F6 RID: 246
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000F7 RID: 247
			private static readonly IntPtr NativeFieldInfoPtr_visible;

			// Token: 0x040000F8 RID: 248
			private static readonly IntPtr NativeFieldInfoPtr_interaction;

			// Token: 0x040000F9 RID: 249
			private static readonly IntPtr NativeFieldInfoPtr__hr_5__2;

			// Token: 0x040000FA RID: 250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000FB RID: 251
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000FC RID: 252
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000FD RID: 253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000FE RID: 254
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000FF RID: 255
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200002B RID: 43
		[ObfuscatedName("lotus.CutSceneSetHighlight+<play>d__5")]
		public sealed class _play_d__5 : Object
		{
			// Token: 0x060001A8 RID: 424 RVA: 0x000082E4 File Offset: 0x000064E4
			// Note: this type is marked as 'beforefieldinit'.
			static _play_d__5()
			{
				Il2CppClassPointerStore<CutSceneSetHighlight._play_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutSceneSetHighlight>.NativeClassPtr, "<play>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneSetHighlight._play_d__5>.NativeClassPtr);
				CutSceneSetHighlight._play_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSetHighlight._play_d__5>.NativeClassPtr, "<>1__state");
				CutSceneSetHighlight._play_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSetHighlight._play_d__5>.NativeClassPtr, "<>2__current");
				CutSceneSetHighlight._play_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSetHighlight._play_d__5>.NativeClassPtr, "<>4__this");
				CutSceneSetHighlight._play_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight._play_d__5>.NativeClassPtr, 100663430);
				CutSceneSetHighlight._play_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight._play_d__5>.NativeClassPtr, 100663431);
				CutSceneSetHighlight._play_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight._play_d__5>.NativeClassPtr, 100663432);
				CutSceneSetHighlight._play_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight._play_d__5>.NativeClassPtr, 100663433);
				CutSceneSetHighlight._play_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight._play_d__5>.NativeClassPtr, 100663434);
				CutSceneSetHighlight._play_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSetHighlight._play_d__5>.NativeClassPtr, 100663435);
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x000083C4 File Offset: 0x000065C4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _play_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneSetHighlight._play_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight._play_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001AA RID: 426 RVA: 0x0000840C File Offset: 0x0000660C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight._play_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001AB RID: 427 RVA: 0x00008440 File Offset: 0x00006640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258452, XrefRangeEnd = 1258456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight._play_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060001AC RID: 428 RVA: 0x0000847C File Offset: 0x0000667C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight._play_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001AD RID: 429 RVA: 0x000084BC File Offset: 0x000066BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258456, XrefRangeEnd = 1258461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight._play_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060001AE RID: 430 RVA: 0x000084F0 File Offset: 0x000066F0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSetHighlight._play_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001AF RID: 431 RVA: 0x00002BB0 File Offset: 0x00000DB0
			public _play_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x060001B0 RID: 432 RVA: 0x00008530 File Offset: 0x00006730
			// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002BB9 File Offset: 0x00000DB9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._play_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._play_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x060001B2 RID: 434 RVA: 0x00008558 File Offset: 0x00006758
			// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002BD4 File Offset: 0x00000DD4
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._play_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._play_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060001B4 RID: 436 RVA: 0x00008588 File Offset: 0x00006788
			// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002BF3 File Offset: 0x00000DF3
			public unsafe CutSceneSetHighlight __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._play_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutSceneSetHighlight>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSetHighlight._play_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000100 RID: 256
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000101 RID: 257
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000102 RID: 258
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000103 RID: 259
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000104 RID: 260
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000105 RID: 261
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000106 RID: 262
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000107 RID: 263
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000108 RID: 264
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
