using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000004 RID: 4
	public sealed class MeasureFunction : MulticastDelegate
	{
		// Token: 0x0600000F RID: 15 RVA: 0x0001CD44 File Offset: 0x0001AF44
		// Note: this type is marked as 'beforefieldinit'.
		static MeasureFunction()
		{
			Il2CppClassPointerStore<MeasureFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.Yoga", "MeasureFunction");
			MeasureFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeasureFunction>.NativeClassPtr, 100663301);
			MeasureFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeasureFunction>.NativeClassPtr, 100663302);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0001CD94 File Offset: 0x0001AF94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282405, RefRangeEnd = 282406, XrefRangeStart = 282396, XrefRangeEnd = 282405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeasureFunction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeasureFunction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeasureFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0001CDF0 File Offset: 0x0001AFF0
		[CallerCount(0)]
		public unsafe YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeasureFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020B0 File Offset: 0x000002B0
		public MeasureFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020B9 File Offset: 0x000002B9
		public static implicit operator MeasureFunction(Func<YogaNode, float, YogaMeasureMode, float, YogaMeasureMode, YogaSize> A_0)
		{
			return DelegateSupport.ConvertDelegate<MeasureFunction>(A_0);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020C1 File Offset: 0x000002C1
		public static MeasureFunction operator +(MeasureFunction A_0, MeasureFunction A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MeasureFunction>();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020CF File Offset: 0x000002CF
		public static MeasureFunction operator -(MeasureFunction A_0, MeasureFunction A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MeasureFunction>();
			}
			return delegate2;
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0;
	}
}
