using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.LowLevel
{
	// Token: 0x020001C7 RID: 455
	public sealed class PlayerLoopSystem : ValueType
	{
		// Token: 0x060020E2 RID: 8418 RVA: 0x000917C0 File Offset: 0x0008F9C0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerLoopSystem()
		{
			Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.LowLevel", "PlayerLoopSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr);
			PlayerLoopSystem.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "type");
			PlayerLoopSystem.NativeFieldInfoPtr_subSystemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "subSystemList");
			PlayerLoopSystem.NativeFieldInfoPtr_updateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "updateDelegate");
			PlayerLoopSystem.NativeFieldInfoPtr_updateFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "updateFunction");
			PlayerLoopSystem.NativeFieldInfoPtr_loopConditionFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "loopConditionFunction");
			PlayerLoopSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, 100667744);
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00091868 File Offset: 0x0008FA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680456, XrefRangeEnd = 680457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLoopSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x0000C75E File Offset: 0x0000A95E
		public PlayerLoopSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x0000C767 File Offset: 0x0000A967
		public PlayerLoopSystem()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr))
		{
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x000918A4 File Offset: 0x0008FAA4
		// (set) Token: 0x060020E7 RID: 8423 RVA: 0x0000C779 File Offset: 0x0000A979
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x000918D4 File Offset: 0x0008FAD4
		// (set) Token: 0x060020E9 RID: 8425 RVA: 0x0000C798 File Offset: 0x0000A998
		public unsafe Il2CppReferenceArray<PlayerLoopSystem> subSystemList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_subSystemList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_subSystemList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x00091904 File Offset: 0x0008FB04
		// (set) Token: 0x060020EB RID: 8427 RVA: 0x0000C7B7 File Offset: 0x0000A9B7
		public unsafe PlayerLoopSystem.UpdateFunction updateDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerLoopSystem.UpdateFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x00091934 File Offset: 0x0008FB34
		// (set) Token: 0x060020ED RID: 8429 RVA: 0x0000C7D6 File Offset: 0x0000A9D6
		public unsafe IntPtr updateFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateFunction)) = value;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060020EE RID: 8430 RVA: 0x0009195C File Offset: 0x0008FB5C
		// (set) Token: 0x060020EF RID: 8431 RVA: 0x0000C7F1 File Offset: 0x0000A9F1
		public unsafe IntPtr loopConditionFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_loopConditionFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_loopConditionFunction)) = value;
			}
		}

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeFieldInfoPtr_subSystemList;

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeFieldInfoPtr_updateDelegate;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeFieldInfoPtr_updateFunction;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeFieldInfoPtr_loopConditionFunction;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000892 RID: 2194
		public sealed class UpdateFunction : MulticastDelegate
		{
			// Token: 0x06003A22 RID: 14882 RVA: 0x000148E2 File Offset: 0x00012AE2
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateFunction()
			{
				Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "UpdateFunction");
				PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr, 100667745);
				PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr, 100667746);
			}

			// Token: 0x06003A23 RID: 14883 RVA: 0x000BDD6C File Offset: 0x000BBF6C
			[CallerCount(288)]
			[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdateFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A24 RID: 14884 RVA: 0x000BDDC8 File Offset: 0x000BBFC8
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A25 RID: 14885 RVA: 0x00014920 File Offset: 0x00012B20
			public UpdateFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003A26 RID: 14886 RVA: 0x00014929 File Offset: 0x00012B29
			public static implicit operator PlayerLoopSystem.UpdateFunction(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<PlayerLoopSystem.UpdateFunction>(A_0);
			}

			// Token: 0x06003A27 RID: 14887 RVA: 0x00014931 File Offset: 0x00012B31
			public static PlayerLoopSystem.UpdateFunction operator +(PlayerLoopSystem.UpdateFunction A_0, PlayerLoopSystem.UpdateFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PlayerLoopSystem.UpdateFunction>();
			}

			// Token: 0x06003A28 RID: 14888 RVA: 0x0001493F File Offset: 0x00012B3F
			public static PlayerLoopSystem.UpdateFunction operator -(PlayerLoopSystem.UpdateFunction A_0, PlayerLoopSystem.UpdateFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PlayerLoopSystem.UpdateFunction>();
				}
				return delegate2;
			}

			// Token: 0x04002CF9 RID: 11513
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CFA RID: 11514
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}
	}
}
