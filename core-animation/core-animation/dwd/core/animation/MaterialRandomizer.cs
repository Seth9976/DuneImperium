using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x0200000B RID: 11
	public class MaterialRandomizer : MonoBehaviour
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00003E80 File Offset: 0x00002080
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialRandomizer()
		{
			Il2CppClassPointerStore<MaterialRandomizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "MaterialRandomizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialRandomizer>.NativeClassPtr);
			MaterialRandomizer.NativeFieldInfoPtr_startDelayFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialRandomizer>.NativeClassPtr, "startDelayFrames");
			MaterialRandomizer.NativeFieldInfoPtr_parameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialRandomizer>.NativeClassPtr, "parameterName");
			MaterialRandomizer.NativeFieldInfoPtr_randomRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialRandomizer>.NativeClassPtr, "randomRange");
			MaterialRandomizer.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialRandomizer>.NativeClassPtr, 100663339);
			MaterialRandomizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialRandomizer>.NativeClassPtr, 100663340);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003F14 File Offset: 0x00002114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263295, XrefRangeEnd = 1263300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialRandomizer.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003F54 File Offset: 0x00002154
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialRandomizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialRandomizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialRandomizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000239E File Offset: 0x0000059E
		public MaterialRandomizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00003F90 File Offset: 0x00002190
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000023A7 File Offset: 0x000005A7
		public unsafe int startDelayFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer.NativeFieldInfoPtr_startDelayFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer.NativeFieldInfoPtr_startDelayFrames)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00003FB8 File Offset: 0x000021B8
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000023C2 File Offset: 0x000005C2
		public unsafe string parameterName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer.NativeFieldInfoPtr_parameterName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer.NativeFieldInfoPtr_parameterName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003FE0 File Offset: 0x000021E0
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000023E1 File Offset: 0x000005E1
		public unsafe Vector2 randomRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer.NativeFieldInfoPtr_randomRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer.NativeFieldInfoPtr_randomRange)) = value;
			}
		}

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_startDelayFrames;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_parameterName;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_randomRange;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000019 RID: 25
		[ObfuscatedName("dwd.core.animation.MaterialRandomizer+<Start>d__3")]
		public sealed class _Start_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x0600010F RID: 271 RVA: 0x00005BDC File Offset: 0x00003DDC
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__3()
			{
				Il2CppClassPointerStore<MaterialRandomizer._Start_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialRandomizer>.NativeClassPtr, "<Start>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialRandomizer._Start_d__3>.NativeClassPtr);
				MaterialRandomizer._Start_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialRandomizer._Start_d__3>.NativeClassPtr, "<>1__state");
				MaterialRandomizer._Start_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialRandomizer._Start_d__3>.NativeClassPtr, "<>2__current");
				MaterialRandomizer._Start_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialRandomizer._Start_d__3>.NativeClassPtr, "<>4__this");
				MaterialRandomizer._Start_d__3.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialRandomizer._Start_d__3>.NativeClassPtr, "<i>5__2");
				MaterialRandomizer._Start_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialRandomizer._Start_d__3>.NativeClassPtr, 100663341);
				MaterialRandomizer._Start_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialRandomizer._Start_d__3>.NativeClassPtr, 100663342);
				MaterialRandomizer._Start_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialRandomizer._Start_d__3>.NativeClassPtr, 100663343);
				MaterialRandomizer._Start_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialRandomizer._Start_d__3>.NativeClassPtr, 100663344);
				MaterialRandomizer._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialRandomizer._Start_d__3>.NativeClassPtr, 100663345);
				MaterialRandomizer._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialRandomizer._Start_d__3>.NativeClassPtr, 100663346);
			}

			// Token: 0x06000110 RID: 272 RVA: 0x00005CD0 File Offset: 0x00003ED0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialRandomizer._Start_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialRandomizer._Start_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000111 RID: 273 RVA: 0x00005D18 File Offset: 0x00003F18
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialRandomizer._Start_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000112 RID: 274 RVA: 0x00005D4C File Offset: 0x00003F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263287, XrefRangeEnd = 1263290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialRandomizer._Start_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x06000113 RID: 275 RVA: 0x00005D88 File Offset: 0x00003F88
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialRandomizer._Start_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000114 RID: 276 RVA: 0x00005DC8 File Offset: 0x00003FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263290, XrefRangeEnd = 1263295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialRandomizer._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x06000115 RID: 277 RVA: 0x00005DFC File Offset: 0x00003FFC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialRandomizer._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000116 RID: 278 RVA: 0x000028F0 File Offset: 0x00000AF0
			public _Start_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000117 RID: 279 RVA: 0x00005E3C File Offset: 0x0000403C
			// (set) Token: 0x06000118 RID: 280 RVA: 0x000028F9 File Offset: 0x00000AF9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer._Start_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer._Start_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000119 RID: 281 RVA: 0x00005E64 File Offset: 0x00004064
			// (set) Token: 0x0600011A RID: 282 RVA: 0x00002914 File Offset: 0x00000B14
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer._Start_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer._Start_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x0600011B RID: 283 RVA: 0x00005E94 File Offset: 0x00004094
			// (set) Token: 0x0600011C RID: 284 RVA: 0x00002933 File Offset: 0x00000B33
			public unsafe MaterialRandomizer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer._Start_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialRandomizer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer._Start_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x0600011D RID: 285 RVA: 0x00005EC4 File Offset: 0x000040C4
			// (set) Token: 0x0600011E RID: 286 RVA: 0x00002952 File Offset: 0x00000B52
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer._Start_d__3.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialRandomizer._Start_d__3.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x0400009C RID: 156
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400009D RID: 157
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400009E RID: 158
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400009F RID: 159
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040000A0 RID: 160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000A1 RID: 161
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000A2 RID: 162
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000A3 RID: 163
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000A4 RID: 164
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000A5 RID: 165
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
