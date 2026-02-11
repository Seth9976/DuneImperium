using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000159 RID: 345
	public sealed class HierarchyEvent : MulticastDelegate
	{
		// Token: 0x060018E0 RID: 6368 RVA: 0x00074D08 File Offset: 0x00072F08
		// Note: this type is marked as 'beforefieldinit'.
		static HierarchyEvent()
		{
			Il2CppClassPointerStore<HierarchyEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "HierarchyEvent");
			HierarchyEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyEvent>.NativeClassPtr, 100666955);
			HierarchyEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisualElement_HierarchyChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyEvent>.NativeClassPtr, 100666956);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00074D58 File Offset: 0x00072F58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320543, RefRangeEnd = 320545, XrefRangeStart = 320534, XrefRangeEnd = 320543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HierarchyEvent(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00074DB4 File Offset: 0x00072FB4
		[CallerCount(0)]
		public unsafe void Invoke(VisualElement ve, HierarchyChangeType changeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HierarchyEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisualElement_HierarchyChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0000B697 File Offset: 0x00009897
		public HierarchyEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0000B6A0 File Offset: 0x000098A0
		public static implicit operator HierarchyEvent(Action<VisualElement, HierarchyChangeType> A_0)
		{
			return DelegateSupport.ConvertDelegate<HierarchyEvent>(A_0);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0000B6A8 File Offset: 0x000098A8
		public static HierarchyEvent operator +(HierarchyEvent A_0, HierarchyEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<HierarchyEvent>();
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0000B6B6 File Offset: 0x000098B6
		public static HierarchyEvent operator -(HierarchyEvent A_0, HierarchyEvent A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<HierarchyEvent>();
			}
			return delegate2;
		}

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisualElement_HierarchyChangeType_0;
	}
}
