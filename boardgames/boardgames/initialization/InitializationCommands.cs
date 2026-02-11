using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace boardgames.initialization
{
	// Token: 0x02000135 RID: 309
	public static class InitializationCommands : Object
	{
		// Token: 0x0600102E RID: 4142 RVA: 0x00042A74 File Offset: 0x00040C74
		// Note: this type is marked as 'beforefieldinit'.
		static InitializationCommands()
		{
			Il2CppClassPointerStore<InitializationCommands>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.initialization", "InitializationCommands");
			InitializationCommands.NativeFieldInfoPtr_AllTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands>.NativeClassPtr, "AllTypes");
			InitializationCommands.NativeMethodInfoPtr_RunAllPlatformInitialization_Public_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands>.NativeClassPtr, 100665630);
			InitializationCommands.NativeMethodInfoPtr_RunAll_Public_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands>.NativeClassPtr, 100665631);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00042AD8 File Offset: 0x00040CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998945, XrefRangeEnd = 998949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator RunAllPlatformInitialization()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands.NativeMethodInfoPtr_RunAllPlatformInitialization_Public_Static_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00042B0C File Offset: 0x00040D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 998953, RefRangeEnd = 998954, XrefRangeStart = 998949, XrefRangeEnd = 998953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator RunAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands.NativeMethodInfoPtr_RunAll_Public_Static_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0000986A File Offset: 0x00007A6A
		public InitializationCommands(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x00042B40 File Offset: 0x00040D40
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x00009873 File Offset: 0x00007A73
		public unsafe static IReadOnlyCollection<Type> AllTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InitializationCommands.NativeFieldInfoPtr_AllTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InitializationCommands.NativeFieldInfoPtr_AllTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeFieldInfoPtr_AllTypes;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_RunAllPlatformInitialization_Public_Static_IEnumerator_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_RunAll_Public_Static_IEnumerator_0;

		// Token: 0x0200026A RID: 618
		[ObfuscatedName("boardgames.initialization.InitializationCommands+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C5A RID: 7258 RVA: 0x00068838 File Offset: 0x00066A38
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializationCommands>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr);
				InitializationCommands.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr, "<>9");
				InitializationCommands.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr, "<>9__2_0");
				InitializationCommands.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr, "<>9__2_1");
				InitializationCommands.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr, "<>9__3_0");
				InitializationCommands.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr, "<>9__3_1");
				InitializationCommands.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr, 100665633);
				InitializationCommands.__c.NativeMethodInfoPtr___cctor_b__1_0_Internal_Boolean_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr, 100665634);
				InitializationCommands.__c.NativeMethodInfoPtr___cctor_b__1_1_Internal_IEnumerable_1_Type_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr, 100665635);
				InitializationCommands.__c.NativeMethodInfoPtr__RunAllPlatformInitialization_b__2_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr, 100665636);
				InitializationCommands.__c.NativeMethodInfoPtr__RunAllPlatformInitialization_b__2_1_Internal_IEnumerator_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr, 100665637);
				InitializationCommands.__c.NativeMethodInfoPtr__RunAll_b__3_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr, 100665638);
				InitializationCommands.__c.NativeMethodInfoPtr__RunAll_b__3_1_Internal_IEnumerator_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr, 100665639);
			}

			// Token: 0x06001C5B RID: 7259 RVA: 0x00068954 File Offset: 0x00066B54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializationCommands.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C5C RID: 7260 RVA: 0x00068990 File Offset: 0x00066B90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998759, XrefRangeEnd = 998768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__1_0(Assembly assembly)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands.__c.NativeMethodInfoPtr___cctor_b__1_0_Internal_Boolean_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C5D RID: 7261 RVA: 0x000689E0 File Offset: 0x00066BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998768, XrefRangeEnd = 998769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Type> __cctor_b__1_1(Assembly assembly)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands.__c.NativeMethodInfoPtr___cctor_b__1_1_Internal_IEnumerable_1_Type_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
				}
			}

			// Token: 0x06001C5E RID: 7262 RVA: 0x00068A30 File Offset: 0x00066C30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998769, XrefRangeEnd = 998776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunAllPlatformInitialization_b__2_0(Type type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands.__c.NativeMethodInfoPtr__RunAllPlatformInitialization_b__2_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C5F RID: 7263 RVA: 0x00068A80 File Offset: 0x00066C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998776, XrefRangeEnd = 998779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _RunAllPlatformInitialization_b__2_1(Type type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands.__c.NativeMethodInfoPtr__RunAllPlatformInitialization_b__2_1_Internal_IEnumerator_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06001C60 RID: 7264 RVA: 0x00068AD0 File Offset: 0x00066CD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998779, XrefRangeEnd = 998786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RunAll_b__3_0(Type type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands.__c.NativeMethodInfoPtr__RunAll_b__3_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C61 RID: 7265 RVA: 0x00068B20 File Offset: 0x00066D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998786, XrefRangeEnd = 998789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _RunAll_b__3_1(Type type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands.__c.NativeMethodInfoPtr__RunAll_b__3_1_Internal_IEnumerator_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06001C62 RID: 7266 RVA: 0x0000F4B6 File Offset: 0x0000D6B6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000864 RID: 2148
			// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00068B70 File Offset: 0x00066D70
			// (set) Token: 0x06001C64 RID: 7268 RVA: 0x0000F4BF File Offset: 0x0000D6BF
			public unsafe static InitializationCommands.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InitializationCommands.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InitializationCommands.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InitializationCommands.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000865 RID: 2149
			// (get) Token: 0x06001C65 RID: 7269 RVA: 0x00068B98 File Offset: 0x00066D98
			// (set) Token: 0x06001C66 RID: 7270 RVA: 0x0000F4D1 File Offset: 0x0000D6D1
			public unsafe static Func<Type, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InitializationCommands.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InitializationCommands.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000866 RID: 2150
			// (get) Token: 0x06001C67 RID: 7271 RVA: 0x00068BC0 File Offset: 0x00066DC0
			// (set) Token: 0x06001C68 RID: 7272 RVA: 0x0000F4E3 File Offset: 0x0000D6E3
			public unsafe static Func<Type, IEnumerator> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InitializationCommands.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InitializationCommands.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000867 RID: 2151
			// (get) Token: 0x06001C69 RID: 7273 RVA: 0x00068BE8 File Offset: 0x00066DE8
			// (set) Token: 0x06001C6A RID: 7274 RVA: 0x0000F4F5 File Offset: 0x0000D6F5
			public unsafe static Func<Type, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InitializationCommands.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InitializationCommands.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000868 RID: 2152
			// (get) Token: 0x06001C6B RID: 7275 RVA: 0x00068C10 File Offset: 0x00066E10
			// (set) Token: 0x06001C6C RID: 7276 RVA: 0x0000F507 File Offset: 0x0000D707
			public unsafe static Func<Type, IEnumerator> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InitializationCommands.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InitializationCommands.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400113D RID: 4413
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400113E RID: 4414
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400113F RID: 4415
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04001140 RID: 4416
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001141 RID: 4417
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04001142 RID: 4418
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001143 RID: 4419
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_0_Internal_Boolean_Assembly_0;

			// Token: 0x04001144 RID: 4420
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_1_Internal_IEnumerable_1_Type_Assembly_0;

			// Token: 0x04001145 RID: 4421
			private static readonly IntPtr NativeMethodInfoPtr__RunAllPlatformInitialization_b__2_0_Internal_Boolean_Type_0;

			// Token: 0x04001146 RID: 4422
			private static readonly IntPtr NativeMethodInfoPtr__RunAllPlatformInitialization_b__2_1_Internal_IEnumerator_Type_0;

			// Token: 0x04001147 RID: 4423
			private static readonly IntPtr NativeMethodInfoPtr__RunAll_b__3_0_Internal_Boolean_Type_0;

			// Token: 0x04001148 RID: 4424
			private static readonly IntPtr NativeMethodInfoPtr__RunAll_b__3_1_Internal_IEnumerator_Type_0;
		}

		// Token: 0x0200026B RID: 619
		[ObfuscatedName("boardgames.initialization.InitializationCommands+<RunAll>d__3")]
		public sealed class _RunAll_d__3 : Object
		{
			// Token: 0x06001C6D RID: 7277 RVA: 0x00068C38 File Offset: 0x00066E38
			// Note: this type is marked as 'beforefieldinit'.
			static _RunAll_d__3()
			{
				Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializationCommands>.NativeClassPtr, "<RunAll>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr);
				InitializationCommands._RunAll_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr, "<>1__state");
				InitializationCommands._RunAll_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr, "<>2__current");
				InitializationCommands._RunAll_d__3.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr, "<>7__wrap1");
				InitializationCommands._RunAll_d__3.NativeFieldInfoPtr__initializeCommand_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr, "<initializeCommand>5__3");
				InitializationCommands._RunAll_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr, 100665640);
				InitializationCommands._RunAll_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr, 100665641);
				InitializationCommands._RunAll_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr, 100665642);
				InitializationCommands._RunAll_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr, 100665643);
				InitializationCommands._RunAll_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr, 100665644);
				InitializationCommands._RunAll_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr, 100665645);
				InitializationCommands._RunAll_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr, 100665646);
			}

			// Token: 0x06001C6E RID: 7278 RVA: 0x00068D40 File Offset: 0x00066F40
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunAll_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializationCommands._RunAll_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAll_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C6F RID: 7279 RVA: 0x00068D88 File Offset: 0x00066F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998789, XrefRangeEnd = 998794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAll_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C70 RID: 7280 RVA: 0x00068DBC File Offset: 0x00066FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998794, XrefRangeEnd = 998859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAll_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C71 RID: 7281 RVA: 0x00068DF8 File Offset: 0x00066FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998859, XrefRangeEnd = 998862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAll_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700086D RID: 2157
			// (get) Token: 0x06001C72 RID: 7282 RVA: 0x00068E2C File Offset: 0x0006702C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAll_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C73 RID: 7283 RVA: 0x00068E6C File Offset: 0x0006706C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998862, XrefRangeEnd = 998867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAll_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700086E RID: 2158
			// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00068EA0 File Offset: 0x000670A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAll_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C75 RID: 7285 RVA: 0x0000F519 File Offset: 0x0000D719
			public _RunAll_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000869 RID: 2153
			// (get) Token: 0x06001C76 RID: 7286 RVA: 0x00068EE0 File Offset: 0x000670E0
			// (set) Token: 0x06001C77 RID: 7287 RVA: 0x0000F522 File Offset: 0x0000D722
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAll_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAll_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700086A RID: 2154
			// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00068F08 File Offset: 0x00067108
			// (set) Token: 0x06001C79 RID: 7289 RVA: 0x0000F53D File Offset: 0x0000D73D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAll_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAll_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086B RID: 2155
			// (get) Token: 0x06001C7A RID: 7290 RVA: 0x00068F38 File Offset: 0x00067138
			// (set) Token: 0x06001C7B RID: 7291 RVA: 0x0000F55C File Offset: 0x0000D75C
			public unsafe IEnumerator<IEnumerator> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAll_d__3.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAll_d__3.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086C RID: 2156
			// (get) Token: 0x06001C7C RID: 7292 RVA: 0x00068F68 File Offset: 0x00067168
			// (set) Token: 0x06001C7D RID: 7293 RVA: 0x0000F57B File Offset: 0x0000D77B
			public unsafe IEnumerator _initializeCommand_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAll_d__3.NativeFieldInfoPtr__initializeCommand_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAll_d__3.NativeFieldInfoPtr__initializeCommand_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001149 RID: 4425
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400114A RID: 4426
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400114B RID: 4427
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400114C RID: 4428
			private static readonly IntPtr NativeFieldInfoPtr__initializeCommand_5__3;

			// Token: 0x0400114D RID: 4429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400114E RID: 4430
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400114F RID: 4431
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001150 RID: 4432
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001151 RID: 4433
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001152 RID: 4434
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001153 RID: 4435
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200026C RID: 620
		[ObfuscatedName("boardgames.initialization.InitializationCommands+<RunAllPlatformInitialization>d__2")]
		public sealed class _RunAllPlatformInitialization_d__2 : Object
		{
			// Token: 0x06001C7E RID: 7294 RVA: 0x00068F98 File Offset: 0x00067198
			// Note: this type is marked as 'beforefieldinit'.
			static _RunAllPlatformInitialization_d__2()
			{
				Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializationCommands>.NativeClassPtr, "<RunAllPlatformInitialization>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr);
				InitializationCommands._RunAllPlatformInitialization_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr, "<>1__state");
				InitializationCommands._RunAllPlatformInitialization_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr, "<>2__current");
				InitializationCommands._RunAllPlatformInitialization_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr, "<>7__wrap1");
				InitializationCommands._RunAllPlatformInitialization_d__2.NativeFieldInfoPtr__initializeCommand_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr, "<initializeCommand>5__3");
				InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr, 100665647);
				InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr, 100665648);
				InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr, 100665649);
				InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr, 100665650);
				InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr, 100665651);
				InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr, 100665652);
				InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr, 100665653);
			}

			// Token: 0x06001C7F RID: 7295 RVA: 0x000690A0 File Offset: 0x000672A0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunAllPlatformInitialization_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializationCommands._RunAllPlatformInitialization_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C80 RID: 7296 RVA: 0x000690E8 File Offset: 0x000672E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998867, XrefRangeEnd = 998872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C81 RID: 7297 RVA: 0x0006911C File Offset: 0x0006731C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998872, XrefRangeEnd = 998937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C82 RID: 7298 RVA: 0x00069158 File Offset: 0x00067358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998937, XrefRangeEnd = 998940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000873 RID: 2163
			// (get) Token: 0x06001C83 RID: 7299 RVA: 0x0006918C File Offset: 0x0006738C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C84 RID: 7300 RVA: 0x000691CC File Offset: 0x000673CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998940, XrefRangeEnd = 998945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000874 RID: 2164
			// (get) Token: 0x06001C85 RID: 7301 RVA: 0x00069200 File Offset: 0x00067400
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationCommands._RunAllPlatformInitialization_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C86 RID: 7302 RVA: 0x0000F59A File Offset: 0x0000D79A
			public _RunAllPlatformInitialization_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700086F RID: 2159
			// (get) Token: 0x06001C87 RID: 7303 RVA: 0x00069240 File Offset: 0x00067440
			// (set) Token: 0x06001C88 RID: 7304 RVA: 0x0000F5A3 File Offset: 0x0000D7A3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAllPlatformInitialization_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAllPlatformInitialization_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000870 RID: 2160
			// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00069268 File Offset: 0x00067468
			// (set) Token: 0x06001C8A RID: 7306 RVA: 0x0000F5BE File Offset: 0x0000D7BE
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAllPlatformInitialization_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAllPlatformInitialization_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000871 RID: 2161
			// (get) Token: 0x06001C8B RID: 7307 RVA: 0x00069298 File Offset: 0x00067498
			// (set) Token: 0x06001C8C RID: 7308 RVA: 0x0000F5DD File Offset: 0x0000D7DD
			public unsafe IEnumerator<IEnumerator> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAllPlatformInitialization_d__2.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAllPlatformInitialization_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000872 RID: 2162
			// (get) Token: 0x06001C8D RID: 7309 RVA: 0x000692C8 File Offset: 0x000674C8
			// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0000F5FC File Offset: 0x0000D7FC
			public unsafe IEnumerator _initializeCommand_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAllPlatformInitialization_d__2.NativeFieldInfoPtr__initializeCommand_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationCommands._RunAllPlatformInitialization_d__2.NativeFieldInfoPtr__initializeCommand_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001154 RID: 4436
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001155 RID: 4437
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001156 RID: 4438
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001157 RID: 4439
			private static readonly IntPtr NativeFieldInfoPtr__initializeCommand_5__3;

			// Token: 0x04001158 RID: 4440
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001159 RID: 4441
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400115A RID: 4442
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400115B RID: 4443
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400115C RID: 4444
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400115D RID: 4445
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400115E RID: 4446
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
