using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ImaginationOverflow.UniversalDeepLinking
{
	// Token: 0x02000012 RID: 18
	public class UniversalDeeplinkingRuntimeScript : MonoBehaviour
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x00005850 File Offset: 0x00003A50
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalDeeplinkingRuntimeScript()
		{
			Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking", "UniversalDeeplinkingRuntimeScript");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr);
			UniversalDeeplinkingRuntimeScript.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr, "Instance");
			UniversalDeeplinkingRuntimeScript.NativeFieldInfoPtr__tasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr, "_tasks");
			UniversalDeeplinkingRuntimeScript.NativeFieldInfoPtr__onJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr, "_onJob");
			UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr, 100663440);
			UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr, 100663441);
			UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr, 100663442);
			UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_Schedule_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr, 100663443);
			UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr, 100663444);
			UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr, 100663445);
			UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_CallDeepLinkManagerAfterDelay_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr, 100663446);
			UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr, 100663447);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000595C File Offset: 0x00003B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240995, XrefRangeEnd = 1240999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005990 File Offset: 0x00003B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240999, XrefRangeEnd = 1241004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000059C4 File Offset: 0x00003BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241004, XrefRangeEnd = 1241016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000059F8 File Offset: 0x00003BF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1241025, RefRangeEnd = 1241026, XrefRangeStart = 1241016, XrefRangeEnd = 1241025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Schedule(Action a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_Schedule_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005A3C File Offset: 0x00003C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241026, XrefRangeEnd = 1241032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationPause(bool pauseStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pauseStatus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005A7C File Offset: 0x00003C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241032, XrefRangeEnd = 1241038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationFocus(bool focus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref focus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005ABC File Offset: 0x00003CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241038, XrefRangeEnd = 1241043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CallDeepLinkManagerAfterDelay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr_CallDeepLinkManagerAfterDelay_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00005AFC File Offset: 0x00003CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241043, XrefRangeEnd = 1241051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalDeeplinkingRuntimeScript()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000024C7 File Offset: 0x000006C7
		public UniversalDeeplinkingRuntimeScript(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00005B38 File Offset: 0x00003D38
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000024D0 File Offset: 0x000006D0
		public unsafe static UniversalDeeplinkingRuntimeScript Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalDeeplinkingRuntimeScript.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalDeeplinkingRuntimeScript>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalDeeplinkingRuntimeScript.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00005B60 File Offset: 0x00003D60
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000024E2 File Offset: 0x000006E2
		public unsafe List<Action> _tasks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalDeeplinkingRuntimeScript.NativeFieldInfoPtr__tasks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalDeeplinkingRuntimeScript.NativeFieldInfoPtr__tasks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00005B90 File Offset: 0x00003D90
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002501 File Offset: 0x00000701
		public unsafe bool _onJob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalDeeplinkingRuntimeScript.NativeFieldInfoPtr__onJob);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalDeeplinkingRuntimeScript.NativeFieldInfoPtr__onJob)) = value;
			}
		}

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr__tasks;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr__onJob;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Void_Action_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_CallDeepLinkManagerAfterDelay_Public_IEnumerator_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200001E RID: 30
		[ObfuscatedName("ImaginationOverflow.UniversalDeepLinking.UniversalDeeplinkingRuntimeScript+<CallDeepLinkManagerAfterDelay>d__9")]
		public sealed class _CallDeepLinkManagerAfterDelay_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x06000174 RID: 372 RVA: 0x00007AB4 File Offset: 0x00005CB4
			// Note: this type is marked as 'beforefieldinit'.
			static _CallDeepLinkManagerAfterDelay_d__9()
			{
				Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript>.NativeClassPtr, "<CallDeepLinkManagerAfterDelay>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9>.NativeClassPtr);
				UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9>.NativeClassPtr, "<>1__state");
				UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9>.NativeClassPtr, "<>2__current");
				UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9>.NativeClassPtr, "<>4__this");
				UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9>.NativeClassPtr, 100663448);
				UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9>.NativeClassPtr, 100663449);
				UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9>.NativeClassPtr, 100663450);
				UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9>.NativeClassPtr, 100663451);
				UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9>.NativeClassPtr, 100663452);
				UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9>.NativeClassPtr, 100663453);
			}

			// Token: 0x06000175 RID: 373 RVA: 0x00007B94 File Offset: 0x00005D94
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CallDeepLinkManagerAfterDelay_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000176 RID: 374 RVA: 0x00007BDC File Offset: 0x00005DDC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000177 RID: 375 RVA: 0x00007C10 File Offset: 0x00005E10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240984, XrefRangeEnd = 1240990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000178 RID: 376 RVA: 0x00007C4C File Offset: 0x00005E4C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000179 RID: 377 RVA: 0x00007C8C File Offset: 0x00005E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240990, XrefRangeEnd = 1240995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x0600017A RID: 378 RVA: 0x00007CC0 File Offset: 0x00005EC0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600017B RID: 379 RVA: 0x00002810 File Offset: 0x00000A10
			public _CallDeepLinkManagerAfterDelay_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x0600017C RID: 380 RVA: 0x00007D00 File Offset: 0x00005F00
			// (set) Token: 0x0600017D RID: 381 RVA: 0x00002819 File Offset: 0x00000A19
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x0600017E RID: 382 RVA: 0x00007D28 File Offset: 0x00005F28
			// (set) Token: 0x0600017F RID: 383 RVA: 0x00002834 File Offset: 0x00000A34
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000180 RID: 384 RVA: 0x00007D58 File Offset: 0x00005F58
			// (set) Token: 0x06000181 RID: 385 RVA: 0x00002853 File Offset: 0x00000A53
			public unsafe UniversalDeeplinkingRuntimeScript __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalDeeplinkingRuntimeScript>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalDeeplinkingRuntimeScript._CallDeepLinkManagerAfterDelay_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000FF RID: 255
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000100 RID: 256
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000101 RID: 257
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000102 RID: 258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000103 RID: 259
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000104 RID: 260
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000105 RID: 261
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000106 RID: 262
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000107 RID: 263
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
