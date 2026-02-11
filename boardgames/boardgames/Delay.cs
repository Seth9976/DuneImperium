using System;
using Canis.messages.effect;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

// Token: 0x0200000D RID: 13
public class Delay : Command
{
	// Token: 0x06000087 RID: 135 RVA: 0x000124B4 File Offset: 0x000106B4
	// Note: this type is marked as 'beforefieldinit'.
	static Delay()
	{
		Il2CppClassPointerStore<Delay>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "Delay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Delay>.NativeClassPtr);
		Delay.NativeFieldInfoPtr_DelaySeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delay>.NativeClassPtr, "DelaySeconds");
		Delay.NativeFieldInfoPtr_DelayMagnitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delay>.NativeClassPtr, "DelayMagnitude");
		Delay.NativeMethodInfoPtr__ctor_Public_Void_AIDelayEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delay>.NativeClassPtr, 100663392);
		Delay.NativeMethodInfoPtr__ctor_Public_Void_AnimationDelayEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delay>.NativeClassPtr, 100663393);
		Delay.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delay>.NativeClassPtr, 100663394);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00012548 File Offset: 0x00010748
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982739, XrefRangeEnd = 982740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Delay(AIDelayEffect delay)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Delay>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(delay);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delay.NativeMethodInfoPtr__ctor_Public_Void_AIDelayEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00012594 File Offset: 0x00010794
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982740, XrefRangeEnd = 982741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Delay(AnimationDelayEffect delay)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Delay>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(delay);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delay.NativeMethodInfoPtr__ctor_Public_Void_AnimationDelayEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000125E0 File Offset: 0x000107E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982741, XrefRangeEnd = 982746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delay.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002375 File Offset: 0x00000575
	public Delay(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x0600008C RID: 140 RVA: 0x0001262C File Offset: 0x0001082C
	// (set) Token: 0x0600008D RID: 141 RVA: 0x0000237E File Offset: 0x0000057E
	public unsafe static float DelaySeconds
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(Delay.NativeFieldInfoPtr_DelaySeconds, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Delay.NativeFieldInfoPtr_DelaySeconds, (void*)(&value));
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x0600008E RID: 142 RVA: 0x00012648 File Offset: 0x00010848
	// (set) Token: 0x0600008F RID: 143 RVA: 0x0000238C File Offset: 0x0000058C
	public unsafe float DelayMagnitude
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delay.NativeFieldInfoPtr_DelayMagnitude);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delay.NativeFieldInfoPtr_DelayMagnitude)) = value;
		}
	}

	// Token: 0x04000065 RID: 101
	private static readonly IntPtr NativeFieldInfoPtr_DelaySeconds;

	// Token: 0x04000066 RID: 102
	private static readonly IntPtr NativeFieldInfoPtr_DelayMagnitude;

	// Token: 0x04000067 RID: 103
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AIDelayEffect_0;

	// Token: 0x04000068 RID: 104
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationDelayEffect_0;

	// Token: 0x04000069 RID: 105
	private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

	// Token: 0x02000191 RID: 401
	[ObfuscatedName("Delay+<execute>d__4")]
	public sealed class _execute_d__4 : Object
	{
		// Token: 0x06001384 RID: 4996 RVA: 0x0004D4F4 File Offset: 0x0004B6F4
		// Note: this type is marked as 'beforefieldinit'.
		static _execute_d__4()
		{
			Il2CppClassPointerStore<Delay._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Delay>.NativeClassPtr, "<execute>d__4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Delay._execute_d__4>.NativeClassPtr);
			Delay._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delay._execute_d__4>.NativeClassPtr, "<>1__state");
			Delay._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delay._execute_d__4>.NativeClassPtr, "<>2__current");
			Delay._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delay._execute_d__4>.NativeClassPtr, "<>4__this");
			Delay._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delay._execute_d__4>.NativeClassPtr, 100663395);
			Delay._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delay._execute_d__4>.NativeClassPtr, 100663396);
			Delay._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delay._execute_d__4>.NativeClassPtr, 100663397);
			Delay._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delay._execute_d__4>.NativeClassPtr, 100663398);
			Delay._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delay._execute_d__4>.NativeClassPtr, 100663399);
			Delay._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delay._execute_d__4>.NativeClassPtr, 100663400);
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0004D5D4 File Offset: 0x0004B7D4
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _execute_d__4(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Delay._execute_d__4>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delay._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0004D61C File Offset: 0x0004B81C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delay._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0004D650 File Offset: 0x0004B850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982729, XrefRangeEnd = 982734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delay._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x0004D68C File Offset: 0x0004B88C
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delay._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0004D6CC File Offset: 0x0004B8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982734, XrefRangeEnd = 982739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delay._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x0004D700 File Offset: 0x0004B900
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delay._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0000B1D4 File Offset: 0x000093D4
		public _execute_d__4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x0004D740 File Offset: 0x0004B940
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x0000B1DD File Offset: 0x000093DD
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delay._execute_d__4.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delay._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x0004D768 File Offset: 0x0004B968
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x0000B1F8 File Offset: 0x000093F8
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delay._execute_d__4.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delay._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x0004D798 File Offset: 0x0004B998
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x0000B217 File Offset: 0x00009417
		public unsafe Delay __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delay._execute_d__4.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delay._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
