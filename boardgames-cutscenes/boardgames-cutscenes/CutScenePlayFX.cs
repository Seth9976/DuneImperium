using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace lotus
{
	// Token: 0x0200000F RID: 15
	public class CutScenePlayFX : CutSceneAction
	{
		// Token: 0x0600007F RID: 127 RVA: 0x000048DC File Offset: 0x00002ADC
		// Note: this type is marked as 'beforefieldinit'.
		static CutScenePlayFX()
		{
			Il2CppClassPointerStore<CutScenePlayFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "CutScenePlayFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutScenePlayFX>.NativeClassPtr);
			CutScenePlayFX.NativeFieldInfoPtr_viewKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayFX>.NativeClassPtr, "viewKey");
			CutScenePlayFX.NativeFieldInfoPtr_blockOnAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayFX>.NativeClassPtr, "blockOnAnimation");
			CutScenePlayFX.NativeMethodInfoPtr_Play_Public_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayFX>.NativeClassPtr, 100663396);
			CutScenePlayFX.NativeMethodInfoPtr_play_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayFX>.NativeClassPtr, 100663397);
			CutScenePlayFX.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayFX>.NativeClassPtr, 100663398);
			CutScenePlayFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayFX>.NativeClassPtr, 100663399);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004984 File Offset: 0x00002B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258386, XrefRangeEnd = 1258395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutScenePlayFX.NativeMethodInfoPtr_Play_Public_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000049D0 File Offset: 0x00002BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258395, XrefRangeEnd = 1258400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayFX.NativeMethodInfoPtr_play_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004A10 File Offset: 0x00002C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258400, XrefRangeEnd = 1258403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutScenePlayFX.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004A54 File Offset: 0x00002C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutScenePlayFX()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutScenePlayFX>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002346 File Offset: 0x00000546
		public CutScenePlayFX(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00004A90 File Offset: 0x00002C90
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0000234F File Offset: 0x0000054F
		public unsafe string viewKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayFX.NativeFieldInfoPtr_viewKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayFX.NativeFieldInfoPtr_viewKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00004AB8 File Offset: 0x00002CB8
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000236E File Offset: 0x0000056E
		public unsafe bool blockOnAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayFX.NativeFieldInfoPtr_blockOnAnimation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayFX.NativeFieldInfoPtr_blockOnAnimation)) = value;
			}
		}

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_viewKey;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_blockOnAnimation;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Command_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_play_Private_IEnumerator_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000028 RID: 40
		[ObfuscatedName("lotus.CutScenePlayFX+<play>d__3")]
		public sealed class _play_d__3 : Object
		{
			// Token: 0x0600017A RID: 378 RVA: 0x000079F0 File Offset: 0x00005BF0
			// Note: this type is marked as 'beforefieldinit'.
			static _play_d__3()
			{
				Il2CppClassPointerStore<CutScenePlayFX._play_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutScenePlayFX>.NativeClassPtr, "<play>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutScenePlayFX._play_d__3>.NativeClassPtr);
				CutScenePlayFX._play_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayFX._play_d__3>.NativeClassPtr, "<>1__state");
				CutScenePlayFX._play_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayFX._play_d__3>.NativeClassPtr, "<>2__current");
				CutScenePlayFX._play_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutScenePlayFX._play_d__3>.NativeClassPtr, "<>4__this");
				CutScenePlayFX._play_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayFX._play_d__3>.NativeClassPtr, 100663400);
				CutScenePlayFX._play_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayFX._play_d__3>.NativeClassPtr, 100663401);
				CutScenePlayFX._play_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayFX._play_d__3>.NativeClassPtr, 100663402);
				CutScenePlayFX._play_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayFX._play_d__3>.NativeClassPtr, 100663403);
				CutScenePlayFX._play_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayFX._play_d__3>.NativeClassPtr, 100663404);
				CutScenePlayFX._play_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutScenePlayFX._play_d__3>.NativeClassPtr, 100663405);
			}

			// Token: 0x0600017B RID: 379 RVA: 0x00007AD0 File Offset: 0x00005CD0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _play_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutScenePlayFX._play_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayFX._play_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600017C RID: 380 RVA: 0x00007B18 File Offset: 0x00005D18
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayFX._play_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600017D RID: 381 RVA: 0x00007B4C File Offset: 0x00005D4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258368, XrefRangeEnd = 1258381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayFX._play_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600017E RID: 382 RVA: 0x00007B88 File Offset: 0x00005D88
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayFX._play_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600017F RID: 383 RVA: 0x00007BC8 File Offset: 0x00005DC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258381, XrefRangeEnd = 1258386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayFX._play_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000180 RID: 384 RVA: 0x00007BFC File Offset: 0x00005DFC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutScenePlayFX._play_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000181 RID: 385 RVA: 0x00002A54 File Offset: 0x00000C54
			public _play_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000182 RID: 386 RVA: 0x00007C3C File Offset: 0x00005E3C
			// (set) Token: 0x06000183 RID: 387 RVA: 0x00002A5D File Offset: 0x00000C5D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayFX._play_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayFX._play_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000184 RID: 388 RVA: 0x00007C64 File Offset: 0x00005E64
			// (set) Token: 0x06000185 RID: 389 RVA: 0x00002A78 File Offset: 0x00000C78
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayFX._play_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayFX._play_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000186 RID: 390 RVA: 0x00007C94 File Offset: 0x00005E94
			// (set) Token: 0x06000187 RID: 391 RVA: 0x00002A97 File Offset: 0x00000C97
			public unsafe CutScenePlayFX __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayFX._play_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutScenePlayFX>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutScenePlayFX._play_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000E3 RID: 227
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000E4 RID: 228
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000E5 RID: 229
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000E6 RID: 230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000E7 RID: 231
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000E8 RID: 232
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000E9 RID: 233
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000EA RID: 234
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000EB RID: 235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
