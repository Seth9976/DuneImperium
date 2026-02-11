using System;
using Canis.actions;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000BF RID: 191
	public sealed class StateBehavior<TMatch, TActiveAbility, TAbilityDefinition> : MulticastDelegate where TMatch : Match where TActiveAbility : ActiveAbility<TMatch, TAbilityDefinition> where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
	{
		// Token: 0x060008CF RID: 2255 RVA: 0x0003D85C File Offset: 0x0003BA5C
		// Note: this type is marked as 'beforefieldinit'.
		static StateBehavior()
		{
			Il2CppClassPointerStore<StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "StateBehavior`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
			})).TypeHandle.value);
			StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665118);
			StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665119);
			StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TActiveAbility_TMatch_Context_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665120);
			StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_Action_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665121);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0003D934 File Offset: 0x0003BB34
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 561466, RefRangeEnd = 561507, XrefRangeStart = 561457, XrefRangeEnd = 561466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateBehavior(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0003D990 File Offset: 0x0003BB90
		[CallerCount(0)]
		public unsafe IEnumerable<Canis.actions.Action> Invoke(TActiveAbility activeAbility, TMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TActiveAbility).IsValueType)
				{
					TActiveAbility tactiveAbility = activeAbility;
					intPtr = ((tactiveAbility is string) ? IL2CPP.ManagedStringToIl2Cpp(tactiveAbility as string) : IL2CPP.Il2CppObjectBaseToPtr(tactiveAbility as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref activeAbility;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TMatch).IsValueType)
			{
				TMatch tmatch = match;
				intPtr2 = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref match;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr5) : null;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0003DA70 File Offset: 0x0003BC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561507, XrefRangeEnd = 561508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(TActiveAbility activeAbility, TMatch match, Context context, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TActiveAbility).IsValueType)
				{
					TActiveAbility tactiveAbility = activeAbility;
					intPtr = ((tactiveAbility is string) ? IL2CPP.ManagedStringToIl2Cpp(tactiveAbility as string) : IL2CPP.Il2CppObjectBaseToPtr(tactiveAbility as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref activeAbility;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TMatch).IsValueType)
			{
				TMatch tmatch = match;
				intPtr2 = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref match;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TActiveAbility_TMatch_Context_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0003DB78 File Offset: 0x0003BD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Canis.actions.Action> EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_Action_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00005699 File Offset: 0x00003899
		public StateBehavior(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000056A2 File Offset: 0x000038A2
		public static implicit operator StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>(Func<TActiveAbility, TMatch, Context, IEnumerable<Canis.actions.Action>> A_0)
		{
			return DelegateSupport.ConvertDelegate<StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>>(A_0);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000056AA File Offset: 0x000038AA
		public static StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>operator +(StateBehavior<TMatch, TActiveAbility, TAbilityDefinition> A_0, StateBehavior<TMatch, TActiveAbility, TAbilityDefinition> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>>();
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x000056B8 File Offset: 0x000038B8
		public static StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>operator -(StateBehavior<TMatch, TActiveAbility, TAbilityDefinition> A_0, StateBehavior<TMatch, TActiveAbility, TAbilityDefinition> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>>();
			}
			return delegate2;
		}

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TActiveAbility_TMatch_Context_AsyncCallback_Object_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_Action_IAsyncResult_0;
	}
}
