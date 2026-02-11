using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000263 RID: 611
	public sealed class PlayableBinding : ValueType
	{
		// Token: 0x060029AC RID: 10668 RVA: 0x000ACAC4 File Offset: 0x000AACC4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableBinding()
		{
			Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr);
			PlayableBinding.NativeFieldInfoPtr_m_StreamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_StreamName");
			PlayableBinding.NativeFieldInfoPtr_m_SourceObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_SourceObject");
			PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_SourceBindingType");
			PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_CreateOutputMethod");
			PlayableBinding.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "None");
			PlayableBinding.NativeFieldInfoPtr_DefaultDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "DefaultDuration");
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x00010208 File Offset: 0x0000E408
		public PlayableBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00010211 File Offset: 0x0000E411
		public PlayableBinding()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr))
		{
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060029AF RID: 10671 RVA: 0x000ACB6C File Offset: 0x000AAD6C
		// (set) Token: 0x060029B0 RID: 10672 RVA: 0x00010223 File Offset: 0x0000E423
		public unsafe string m_StreamName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_StreamName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_StreamName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x000ACB94 File Offset: 0x000AAD94
		// (set) Token: 0x060029B2 RID: 10674 RVA: 0x00010242 File Offset: 0x0000E442
		public unsafe Object m_SourceObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060029B3 RID: 10675 RVA: 0x000ACBC4 File Offset: 0x000AADC4
		// (set) Token: 0x060029B4 RID: 10676 RVA: 0x00010261 File Offset: 0x0000E461
		public unsafe Type m_SourceBindingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x060029B5 RID: 10677 RVA: 0x000ACBF4 File Offset: 0x000AADF4
		// (set) Token: 0x060029B6 RID: 10678 RVA: 0x00010280 File Offset: 0x0000E480
		public unsafe PlayableBinding.CreateOutputMethod m_CreateOutputMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableBinding.CreateOutputMethod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x060029B7 RID: 10679 RVA: 0x000ACC24 File Offset: 0x000AAE24
		// (set) Token: 0x060029B8 RID: 10680 RVA: 0x0001029F File Offset: 0x0000E49F
		public unsafe static Il2CppReferenceArray<PlayableBinding> None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayableBinding.NativeFieldInfoPtr_None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayableBinding>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableBinding.NativeFieldInfoPtr_None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x000ACC4C File Offset: 0x000AAE4C
		// (set) Token: 0x060029BA RID: 10682 RVA: 0x000102B1 File Offset: 0x0000E4B1
		public unsafe static double DefaultDuration
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(PlayableBinding.NativeFieldInfoPtr_DefaultDuration, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableBinding.NativeFieldInfoPtr_DefaultDuration, (void*)(&value));
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x000ACC68 File Offset: 0x000AAE68
		// (set) Token: 0x060029BC RID: 10684 RVA: 0x000102BF File Offset: 0x0000E4BF
		public string streamName
		{
			get
			{
				return this.m_StreamName;
			}
			set
			{
				this.m_StreamName = value;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x060029BD RID: 10685 RVA: 0x000ACC80 File Offset: 0x000AAE80
		// (set) Token: 0x060029BE RID: 10686 RVA: 0x000102C9 File Offset: 0x0000E4C9
		public Object sourceObject
		{
			get
			{
				return this.m_SourceObject;
			}
			set
			{
				this.m_SourceObject = value;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x060029BF RID: 10687 RVA: 0x000ACC98 File Offset: 0x000AAE98
		public Type outputTargetType
		{
			get
			{
				return this.m_SourceBindingType;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x000ACCB0 File Offset: 0x000AAEB0
		// (set) Token: 0x060029C1 RID: 10689 RVA: 0x000102D3 File Offset: 0x0000E4D3
		public Type sourceBindingType
		{
			get
			{
				return this.m_SourceBindingType;
			}
			set
			{
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x000ACCC8 File Offset: 0x000AAEC8
		// (set) Token: 0x060029C3 RID: 10691 RVA: 0x000102D6 File Offset: 0x0000E4D6
		public DataStreamType streamType
		{
			get
			{
				return DataStreamType.None;
			}
			set
			{
			}
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x000ACCDC File Offset: 0x000AAEDC
		public PlayableOutput CreateOutput(PlayableGraph graph)
		{
			bool flag = this.m_CreateOutputMethod != null;
			PlayableOutput playableOutput;
			if (flag)
			{
				playableOutput = this.m_CreateOutputMethod.Invoke(graph, this.m_StreamName);
			}
			else
			{
				playableOutput = PlayableOutput.Null;
			}
			return playableOutput;
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000ACD18 File Offset: 0x000AAF18
		public static PlayableBinding CreateInternal(string name, Object sourceObject, Type sourceType, PlayableBinding.CreateOutputMethod createFunction)
		{
			PlayableBinding playableBinding = null;
			playableBinding.m_StreamName = name;
			playableBinding.m_SourceObject = sourceObject;
			playableBinding.m_SourceBindingType = sourceType;
			playableBinding.m_CreateOutputMethod = createFunction;
			return playableBinding;
		}

		// Token: 0x040024E4 RID: 9444
		private static readonly IntPtr NativeFieldInfoPtr_m_StreamName;

		// Token: 0x040024E5 RID: 9445
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceObject;

		// Token: 0x040024E6 RID: 9446
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceBindingType;

		// Token: 0x040024E7 RID: 9447
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateOutputMethod;

		// Token: 0x040024E8 RID: 9448
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x040024E9 RID: 9449
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDuration;

		// Token: 0x02000A05 RID: 2565
		public sealed class CreateOutputMethod : MulticastDelegate
		{
			// Token: 0x06003D22 RID: 15650 RVA: 0x000167A1 File Offset: 0x000149A1
			// Note: this type is marked as 'beforefieldinit'.
			static CreateOutputMethod()
			{
				Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "CreateOutputMethod");
				PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr, 100668556);
				PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr, 100668557);
			}

			// Token: 0x06003D23 RID: 15651 RVA: 0x000BEEBC File Offset: 0x000BD0BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 685765, XrefRangeEnd = 685768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreateOutputMethod(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003D24 RID: 15652 RVA: 0x000BEF18 File Offset: 0x000BD118
			[CallerCount(0)]
			public unsafe PlayableOutput Invoke(PlayableGraph graph, string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref graph;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003D25 RID: 15653 RVA: 0x000167DF File Offset: 0x000149DF
			public CreateOutputMethod(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003D26 RID: 15654 RVA: 0x000167E8 File Offset: 0x000149E8
			public static implicit operator PlayableBinding.CreateOutputMethod(Func<PlayableGraph, string, PlayableOutput> A_0)
			{
				return DelegateSupport.ConvertDelegate<PlayableBinding.CreateOutputMethod>(A_0);
			}

			// Token: 0x06003D27 RID: 15655 RVA: 0x000167F0 File Offset: 0x000149F0
			public static PlayableBinding.CreateOutputMethod operator +(PlayableBinding.CreateOutputMethod A_0, PlayableBinding.CreateOutputMethod A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PlayableBinding.CreateOutputMethod>();
			}

			// Token: 0x06003D28 RID: 15656 RVA: 0x000167FE File Offset: 0x000149FE
			public static PlayableBinding.CreateOutputMethod operator -(PlayableBinding.CreateOutputMethod A_0, PlayableBinding.CreateOutputMethod A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PlayableBinding.CreateOutputMethod>();
				}
				return delegate2;
			}

			// Token: 0x04002D4E RID: 11598
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002D4F RID: 11599
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0;
		}
	}
}
