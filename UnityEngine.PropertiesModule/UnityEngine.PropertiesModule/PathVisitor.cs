using System;

namespace Unity.Properties
{
	// Token: 0x02000056 RID: 86
	public abstract class PathVisitor
	{
		// Token: 0x060001CC RID: 460 RVA: 0x00002F8B File Offset: 0x0000118B
		public virtual void Reset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00002F98 File Offset: 0x00001198
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002FA5 File Offset: 0x000011A5
		public IProperty Property
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00002FB2 File Offset: 0x000011B2
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002FBF File Offset: 0x000011BF
		public bool ReadonlyVisit
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002FCC File Offset: 0x000011CC
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002FD9 File Offset: 0x000011D9
		public VisitReturnCode ReturnCode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002FE6 File Offset: 0x000011E6
		public void Unity.Properties.IPropertyBagVisitor.Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002FF3 File Offset: 0x000011F3
		public void Unity.Properties.IPropertyVisitor.Visit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00003000 File Offset: 0x00001200
		public virtual void VisitPath<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
		{
		}
	}
}
