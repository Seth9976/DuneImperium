using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200002B RID: 43
	public class TweenRunner<T> : global::Il2CppSystem.Object where T : new()
	{
		// Token: 0x060003D5 RID: 981 RVA: 0x00016018 File Offset: 0x00014218
		// Note: this type is marked as 'beforefieldinit'.
		static TweenRunner()
		{
			Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TweenRunner`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr);
			TweenRunner<T>.NativeFieldInfoPtr_m_CoroutineContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, "m_CoroutineContainer");
			TweenRunner<T>.NativeFieldInfoPtr_m_Tween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, "m_Tween");
			TweenRunner<T>.NativeMethodInfoPtr_Start_Private_Static_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100663658);
			TweenRunner<T>.NativeMethodInfoPtr_Init_Public_Void_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100663659);
			TweenRunner<T>.NativeMethodInfoPtr_StartTween_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100663660);
			TweenRunner<T>.NativeMethodInfoPtr_StopTween_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100663661);
			TweenRunner<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, 100663662);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00016110 File Offset: 0x00014310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038165, XrefRangeEnd = 1038171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Start(T tweenInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = tweenInfo;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref tweenInfo;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>.NativeMethodInfoPtr_Start_Private_Static_IEnumerator_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0001618C File Offset: 0x0001438C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(MonoBehaviour coroutineContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutineContainer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>.NativeMethodInfoPtr_Init_Public_Void_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000161D0 File Offset: 0x000143D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038189, RefRangeEnd = 1038190, XrefRangeStart = 1038171, XrefRangeEnd = 1038189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTween(T info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = info;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref info;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>.NativeMethodInfoPtr_StartTween_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00016248 File Offset: 0x00014448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1038192, RefRangeEnd = 1038194, XrefRangeStart = 1038190, XrefRangeEnd = 1038192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTween()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>.NativeMethodInfoPtr_StopTween_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0001627C File Offset: 0x0001447C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenRunner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00003F18 File Offset: 0x00002118
		public TweenRunner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000162B8 File Offset: 0x000144B8
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00003F21 File Offset: 0x00002121
		public unsafe MonoBehaviour m_CoroutineContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>.NativeFieldInfoPtr_m_CoroutineContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>.NativeFieldInfoPtr_m_CoroutineContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003DE RID: 990 RVA: 0x000162E8 File Offset: 0x000144E8
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00003F40 File Offset: 0x00002140
		public unsafe IEnumerator m_Tween
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>.NativeFieldInfoPtr_m_Tween);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>.NativeFieldInfoPtr_m_Tween), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_m_CoroutineContainer;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_m_Tween;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Static_IEnumerator_T_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_MonoBehaviour_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_StartTween_Public_Void_T_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_StopTween_Public_Void_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200007F RID: 127
		[ObfuscatedName("TMPro.TweenRunner`1+<Start>d__2")]
		public sealed class _Start_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x06000EB7 RID: 3767 RVA: 0x0003B424 File Offset: 0x00039624
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__2()
			{
				Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TweenRunner<T>>.NativeClassPtr, "<Start>d__2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr);
				TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, "<>1__state");
				TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, "<>2__current");
				TweenRunner<T>._Start_d__2.NativeFieldInfoPtr_tweenInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, "tweenInfo");
				TweenRunner<T>._Start_d__2.NativeFieldInfoPtr__elapsedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, "<elapsedTime>5__2");
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100663663);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100663664);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100663665);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100663666);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100663667);
				TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr, 100663668);
			}

			// Token: 0x06000EB8 RID: 3768 RVA: 0x0003B554 File Offset: 0x00039754
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenRunner<T>._Start_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000EB9 RID: 3769 RVA: 0x0003B59C File Offset: 0x0003979C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EBA RID: 3770 RVA: 0x0003B5D0 File Offset: 0x000397D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038157, XrefRangeEnd = 1038165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000571 RID: 1393
			// (get) Token: 0x06000EBB RID: 3771 RVA: 0x0003B60C File Offset: 0x0003980C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000EBC RID: 3772 RVA: 0x0003B64C File Offset: 0x0003984C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000572 RID: 1394
			// (get) Token: 0x06000EBD RID: 3773 RVA: 0x0003B680 File Offset: 0x00039880
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenRunner<T>._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000EBE RID: 3774 RVA: 0x00008F23 File Offset: 0x00007123
			public _Start_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700056D RID: 1389
			// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0003B6C0 File Offset: 0x000398C0
			// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x00008F2C File Offset: 0x0000712C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700056E RID: 1390
			// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0003B6E8 File Offset: 0x000398E8
			// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x00008F47 File Offset: 0x00007147
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700056F RID: 1391
			// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x0003B718 File Offset: 0x00039918
			// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x0003B740 File Offset: 0x00039940
			public unsafe T tweenInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr_tweenInfo);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr_tweenInfo);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000570 RID: 1392
			// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x0003B7E8 File Offset: 0x000399E8
			// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x00008F66 File Offset: 0x00007166
			public unsafe float _elapsedTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr__elapsedTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenRunner<T>._Start_d__2.NativeFieldInfoPtr__elapsedTime_5__2)) = value;
				}
			}

			// Token: 0x04000BAA RID: 2986
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000BAB RID: 2987
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000BAC RID: 2988
			private static readonly IntPtr NativeFieldInfoPtr_tweenInfo;

			// Token: 0x04000BAD RID: 2989
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__2;

			// Token: 0x04000BAE RID: 2990
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000BAF RID: 2991
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000BB0 RID: 2992
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000BB1 RID: 2993
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000BB2 RID: 2994
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000BB3 RID: 2995
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
